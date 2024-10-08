﻿using ELibrary.Standard.VB;
using EWebFrameworkCore.Vendor.Services;
using Microsoft.AspNetCore.Http;
using MimeMapping;
using System.Text;

namespace EWebFrameworkCore.Vendor.CloudFileSystem
{
    /// <summary>
    /// FileSystem Compatible Implementations are expected to handle path corrections
    /// </summary>
    public abstract class FileSystemCompatible
    {
        //
        // Summary:
        //     It will return public accessible path for the file. Provided Publicity is set
        //
        // Parameters:
        //   ObjectPath:
        //     FileName - Full relative path to the root container
        //
        //   Attachment:
        //     If attachment, downloadable else inline disposition
        //
        //   DownloadAsFileName:
        //
        //   ContentType:
        //
        //   ExpiryTimeInSeconds:
        //     Time for the file in the path return to expire. 1hr
        public virtual string CreateTemporaryURL(string ObjectPath, bool Attachment, string DownloadAsFileName, string ContentType, int ExpiryTimeInSeconds)
        {
            return ObjectPath;
        }

        //
        // Summary:
        //     It will return public accessible path for the file. Provided Publicity is set
        //
        // Parameters:
        //   ObjectPath:
        //     FileName - Full relative path to the root container
        //
        //   Attachment:
        //     If attachment, downloadable else inline disposition
        //
        //   DownloadAsFileName:
        public virtual string CreateTemporaryURL(string ObjectPath, bool Attachment, string DownloadAsFileName) => CreateTemporaryURL(ObjectPath, Attachment, DownloadAsFileName, MimeUtility.GetMimeMapping(EIO.GetFileName(ObjectPath)), 3600);

        //
        // Summary:
        //     It will return public accessible path for the file. Provided Publicity is set
        //
        // Parameters:
        //   ObjectPath:
        //     FileName - Full relative path to the root container
        //
        //   Attachment:
        //     If attachment, downloadable else inline disposition
        public virtual string CreateTemporaryURL(string ObjectPath, bool Attachment)
        {
            return CreateTemporaryURL(ObjectPath, Attachment, JobCompatibleService.GetArbitraryValidFileName(EIO.GetFileName(ObjectPath)));
        }

        //
        // Summary:
        //     It will return public accessible path for the file. Provided Publicity is set
        //
        // Parameters:
        //   ObjectPath:
        //     FileName - Full relative path to the root container
        public virtual string CreateTemporaryURL(string ObjectPath)
        {
            return CreateTemporaryURL(ObjectPath, Attachment: true);
        }

        //
        // Parameters:
        //   ObjectPath:
        public abstract TemporaryFile GetFileAsDownloaded(string ObjectPath);

        //
        // Parameters:
        //   ObjectPath:
        //
        //   cleanUp:
        public virtual string GetFileAsString(string ObjectPath)
        {
            byte[] fileAsBinary = GetFileAsBinary(ObjectPath);
            return Encoding.UTF8.GetString(fileAsBinary, 0, fileAsBinary.Length);
        }

        //
        // Parameters:
        //   ObjectPath:
        //
        //   cleanUp:
        public virtual byte[] GetFileAsBinary(string ObjectPath)
        {
            try
            {
                using TemporaryFile fileAsDownloaded = GetFileAsDownloaded(ObjectPath);
                byte[] result = File.ReadAllBytes(fileAsDownloaded.FileFullPath);
                return result;
            }
            catch (Exception innerException)
            {
                throw new InvalidOperationException("Unfortunately the file could not be downloaded!", innerException);
            }
        }

        //
        // Summary:
        //     Storage Exists
        public abstract bool StorageExist();

        //
        // Summary:
        //     Save File
        //
        // Parameters:
        //   ObjectPath:
        //
        //   FileFullPath:
        public abstract void SaveFile(string ObjectPath, string FileFullPath);

        public virtual void SaveFile(string ObjectPath, IFormFile UploadedFile)
        {
            using var r = new BinaryReader(UploadedFile.OpenReadStream());
            SaveFileContent(ObjectPath, Contents: r.ReadBytes((int)UploadedFile.Length));
        }

        //
        // Parameters:
        //   ObjectPath:
        //
        //   Contents:
        public virtual void SaveFileContent(string ObjectPath, byte[] Contents)
        {
            using TemporaryFile temporaryFile = new();
            if(!Directory.Exists(Path.GetDirectoryName(temporaryFile.FileFullPath)))
                Directory.CreateDirectory(Path.GetDirectoryName(temporaryFile.FileFullPath)?? throw new InvalidOperationException("Can not create directory of path: " + temporaryFile.FileFullPath) );

            File.WriteAllBytes(temporaryFile.FileFullPath, Contents);
            
            // if save file prevents file deletion, the file remains on the server locally
            SaveFile(ObjectPath, temporaryFile.FileFullPath);
        }

        public abstract Task SaveFileContentAsync(string objectPath, Stream contentStream, string contentType);

        //
        // Parameters:
        //   ObjectPath:
        //
        //   Contents:
        public virtual void SaveFileContent(string ObjectPath, string Contents)
        {
            SaveFileContent(ObjectPath, Encoding.UTF8.GetBytes(Contents));
        }

        //
        // Parameters:
        //   ObjectPath:
        //
        //   Contents:
        public virtual void SaveFileContent(string ObjectPath, Stream Contents)
        {
            using BinaryReader binaryReader = new(Contents);
            SaveFileContent(ObjectPath, binaryReader.ReadBytes((int)Contents.Length));
        }

        //
        // Summary:
        //     File Exists
        //
        // Parameters:
        //   ObjectPath:
        public abstract bool ObjectExists(string ObjectPath);

        //
        // Summary:
        //     Delete object
        //
        // Parameters:
        //   ObjectPath:
        public abstract void DeleteObject(string ObjectPath);
    }

    public static class FileSystemCompatibleExtensions
    {
        public static string ToCloudPathCompatible(this string objectPath)
        {
            return objectPath.Replace(@"\", @"/").Replace(@"//", @"/");
        }

        public static string ToWindowsPathCompatible(this string objectPath)
        {
            return objectPath.Replace(@"/", @"\").Replace(@"\\", @"\");
        }

        public static string ToUnixPathCompatible(this string objectPath)
        {
            return objectPath.ToCloudPathCompatible();
        }
    }
}
