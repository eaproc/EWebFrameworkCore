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

        const int CHUNK_MAX_SIZE_IN_KB = 5000;          // 5MB
        const int FOLDER_EXPIRY_TIME_IN_MINUTES = 30;

        private readonly string uploadIdentifierUuid;
        private readonly ILogger<ChunkFileReceiverService> logger;

        public ChunkFileReceiverService(string uploadIdentifierUuid, ILoggerFactory loggerFactory) { 
            this.uploadIdentifierUuid = uploadIdentifierUuid;

            // create chunk folder if it doesn't exists
            if (!Directory.Exists(ToUploadFolder()) ) Directory.CreateDirectory(ToUploadFolder());

            logger = loggerFactory.CreateLogger<ChunkFileReceiverService>();
        }

        public string ToUploadFolder(string? fileName = null)
        {
            fileName = fileName is null ? string.Empty : Path.Combine(fileName.StartsWith("/") ? "" : "/", fileName);
            return PathHandlers.StoragePath(string.Format("ChunkUploads/{0}", uploadIdentifierUuid + fileName ));
        }

        public ChunkFileReceiverService StoreNewChunk(IFormFile file, int dzChunkIndex)
        {
            string FullFilePath = ToUploadFolder($"{dzChunkIndex}.tmp");
            file.SaveFormFileAs(FullFilePath);

            return this;
        }

        /// <summary>
        /// Note, that the file returned will auto delete on dispose
        /// </summary>
        /// <param name="LimitSizeInMB"></param>
        /// <returns></returns>
        public TemporaryFile ObtainChunkedFile(string desiredFileName, long expectedTotalFileSize, int? LimitSizeInMB = null)
        {
            TemporaryFile fileReceived = new(ToUploadFolder(desiredFileName));

            try
            {
                // Merge File into one
                // Get all files in directory and combine in filestream
                List<string> files = Directory.EnumerateFiles(ToUploadFolder()).OrderBy(s => int.Parse(Path.GetFileNameWithoutExtension(s))).ToList();

                // Merge chunks into one file
                // default buffer size is 4KB,
                // Consider using a larger buffer size for better performance when merging large files
                using (var fStream = new FileStream(fileReceived.FileFullPath, FileMode.Create, FileAccess.Write, FileShare.None, 1048576)) // Using a 1MB buffer
                {
                    foreach (var file in files)
                    {
                        using var sourceStream = File.OpenRead(file);
                        {
                            // default buffer size 80KB
                            sourceStream.CopyTo(fStream, 524288); // Using a 512KB buffer for read operations
                        }
                    }
                    fStream.Flush(); // clean up the remaining buffer, if any is left.
                }

                // Sanity Check if Size doesnt match
                if (fileReceived.Size() != expectedTotalFileSize) throw new InvalidChunkFileUploadException(uuid: uploadIdentifierUuid);

                // Size Limit Check
                if (LimitSizeInMB.HasValue && fileReceived.Size() > LimitSizeInMB.Value * 1024 * 1024) 
                    throw new TooLargeChunkFileUploadException(uuid: uploadIdentifierUuid, uploadedSizeBytes: fileReceived.Size(), limitSizeBytes: LimitSizeInMB.Value * 1024 * 1024);


                return fileReceived;
            }
            catch (Exception)
            {
                fileReceived.Dispose();
                throw;
            }
        }

        public void DisposeAllChunksCompletely()
        {
            DeleteOldFoldersFromSubfolder();
            if (!Directory.Exists(ToUploadFolder())) Directory.Delete(ToUploadFolder(), true);
        }

        private void DeleteOldFoldersFromSubfolder()
        {
            // Get the parent directory info from the subfolder path
            DirectoryInfo directoryInfo = new (ToUploadFolder());

            // Check if the subfolder directory exists
            if (!directoryInfo.Exists) return;

            // Get the parent directory of the given subfolder
            DirectoryInfo? parentDirectory = directoryInfo.Parent;

            if (parentDirectory == null) return;

            // Get all subdirectories from the parent directory
            string[] directories = Directory.GetDirectories(parentDirectory.FullName);

            foreach (var directory in directories)
            {
                try
                {
                    // Get the creation time of the directory
                    DateTime creationTime = Directory.GetCreationTime(directory);

                    // Check if the directory was created more than X minutes ago
                    if (creationTime < DateTime.Now.AddMinutes(-FOLDER_EXPIRY_TIME_IN_MINUTES))
                    {
                        // Delete the directory and all its contents
                        Directory.Delete(directory, true);
                    }
                }
                catch (Exception ex)
                {
                    // Log exceptions, such as if the directory is in use or we do not have permission
                    logger.LogWarning("Failed to delete {directory}: {exMessage}", directory, ex.Message);
                }
            }
        }

        public void Dispose() => DeleteOldFoldersFromSubfolder();
    }
}
