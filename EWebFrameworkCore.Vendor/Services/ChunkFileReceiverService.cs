using EWebFrameworkCore.Vendor.Exceptions;
using EWebFrameworkCore.Vendor.Requests;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace EWebFrameworkCore.Vendor.Services
{
    /// <summary>
    /// Handles chunked file uploads. Only supports local storage at the moment
    /// </summary>
    public class ChunkFileReceiverService: IDisposable
    {
        public const int CHUNK_MAX_SIZE_IN_KB = 5000;          // 5MB
        public const int TOTAL_CHUNKS_MAX_SIZE_IN_KB = 100000; // 100MB
        private const int FOLDER_EXPIRY_TIME_IN_MINUTES = 30;

        private readonly string uploadIdentifierUuid;
        private readonly ILogger<ChunkFileReceiverService> logger;

        public ChunkFileReceiverService(string uploadIdentifierUuid, ILoggerFactory loggerFactory)
        {
            this.uploadIdentifierUuid = uploadIdentifierUuid;
            logger = loggerFactory.CreateLogger<ChunkFileReceiverService>();

            var folderPath = ToUploadFolder();
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
                logger.LogDebug("Created chunk folder at {FolderPath}", folderPath);
            }
        }

        public string ToUploadFolder(string? fileName = null)
        {
            fileName = fileName is null ? string.Empty : Path.Combine(fileName.StartsWith("/") ? "" : "/", fileName);
            var path = PathHandlers.StoragePath(string.Format("ChunkUploads/{0}", uploadIdentifierUuid + fileName));
            logger.LogDebug("Resolved upload folder path: {Path}", path);
            return path;
        }

        public ChunkFileReceiverService StoreNewChunk(IFormFile file, int dzChunkIndex)
        {
            long currentUsageSizeInBytes = GetTotalDirectorySize();
            logger.LogDebug("Current usage before storing new chunk: {CurrentUsageSizeInBytes} bytes", currentUsageSizeInBytes);

            if ((currentUsageSizeInBytes + file.Length) > (TOTAL_CHUNKS_MAX_SIZE_IN_KB * 1024))
            {
                logger.LogWarning("Attempt to exceed storage space. UUID: {UUID}, RequestedSize: {RequestedSize}, CurrentUsage: {CurrentUsage}, Limit: {Limit}",
                    uploadIdentifierUuid, file.Length, currentUsageSizeInBytes, TOTAL_CHUNKS_MAX_SIZE_IN_KB);
                throw new ChunkAllowedTotalFolderSizeExceededException(uuid: uploadIdentifierUuid, chunkSizeInByte: file.Length, currentUsageSizeInBytes: currentUsageSizeInBytes, allowedStorageSizeInKb: TOTAL_CHUNKS_MAX_SIZE_IN_KB);
            }

            string FullFilePath = ToUploadFolder($"{dzChunkIndex}.tmp");
            file.SaveFormFileAs(FullFilePath);
            logger.LogDebug("Stored new chunk at {FullFilePath}", FullFilePath);

            return this;
        }

        public async Task<TemporaryFile> ObtainChunkedFileAsync(string desiredFileName, long expectedTotalFileSizeInBytes, int? LimitSizeInMB = null)
        {
            TemporaryFile fileReceived = new TemporaryFile(ToUploadFolder(desiredFileName));
            logger.LogDebug("Attempting to merge chunks for {FileName}", desiredFileName);

            try
            {
                // Merge File into one
                // Get all files in directory and combine in filestream
                List<string> files = Directory.EnumerateFiles(ToUploadFolder()).OrderBy(s => int.Parse(Path.GetFileNameWithoutExtension(s))).ToList();
                using var fStream = new FileStream(fileReceived.FileFullPath, FileMode.Create, FileAccess.Write, FileShare.None, 1048576);
                foreach (var file in files)
                {
                    using var sourceStream = new FileStream(file, FileMode.Open, FileAccess.Read, FileShare.Read, 524288, useAsync: true);
                    await sourceStream.CopyToAsync(fStream, 524288);
                }
                await fStream.FlushAsync();
                logger.LogDebug("Successfully merged files into {FilePath}", fileReceived.FileFullPath);

                if (fileReceived.Size() != expectedTotalFileSizeInBytes)
                    throw new InvalidChunkFileUploadException(uuid: uploadIdentifierUuid);

                if (LimitSizeInMB.HasValue && fileReceived.Size() > LimitSizeInMB.Value * 1024 * 1024)
                    throw new TooLargeChunkFileUploadException(uuid: uploadIdentifierUuid, uploadedSizeBytes: fileReceived.Size(), limitSizeBytes: LimitSizeInMB.Value * 1024 * 1024);

                return fileReceived;
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Failed to obtain chunked file for {FileName}", desiredFileName);
                fileReceived.Dispose();
                throw;
            }
        }

        public long GetTotalDirectorySize()
        {
            var folder = ToUploadFolder();
            if (!Directory.Exists(folder))
                return 0;

            DirectoryInfo directoryInfo = new DirectoryInfo(folder);
            long size = directoryInfo.GetFiles("*", SearchOption.AllDirectories).Sum(file => file.Length);
            logger.LogDebug("Computed total directory size: {Size} bytes", size);
            return size;
        }

        public void DisposeAllChunksCompletely()
        {
            DeleteOldFoldersFromSubfolder();
            var folderPath = ToUploadFolder();
            if (Directory.Exists(folderPath))
            {
                Directory.Delete(folderPath, true);
                logger.LogDebug("Deleted all chunks and the folder at {FolderPath}", folderPath);
            }
        }

        private void DeleteOldFoldersFromSubfolder()
        {
            var folderPath = ToUploadFolder();
            DirectoryInfo directoryInfo = new DirectoryInfo(folderPath);
            if (!directoryInfo.Exists)
            {
                logger.LogDebug("No subfolder at {FolderPath} to delete", folderPath);
                return;
            }

            DirectoryInfo? parentDirectory = directoryInfo.Parent;
            if (parentDirectory == null)
            {
                logger.LogWarning("No parent directory found for {FolderPath}", folderPath);
                return;
            }

            string[] directories = Directory.GetDirectories(parentDirectory.FullName);
            foreach (var directory in directories)
            {
                try
                {
                    DateTime creationTime = Directory.GetCreationTime(directory);
                    if (creationTime < DateTime.Now.AddMinutes(-FOLDER_EXPIRY_TIME_IN_MINUTES))
                    {
                        Directory.Delete(directory, true);
                        logger.LogDebug("Deleted old directory {Directory}", directory);
                    }
                }
                catch (Exception ex)
                {
                    logger.LogError(ex, "Failed to delete directory {Directory}", directory);
                }
            }
        }

        public void Dispose() => DisposeAllChunksCompletely();
    }
}
