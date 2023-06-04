using ELibrary.Standard.VB;
using EWebFrameworkCore.Vendor.Services;
using MimeMapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EWebFrameworkCore.Vendor.CloudFileSystem
{
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
        public virtual string CreateTemporaryURL(string ObjectPath, bool Attachment, string DownloadAsFileName) => CreateTemporaryURL(ObjectPath, Attachment, DownloadAsFileName, MimeUtility.GetMimeMapping(EIO.getFileName(ObjectPath)), 3600);

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
            return CreateTemporaryURL(ObjectPath, Attachment, BaseClientService.GetArbitraryValidFileName(EIO.getFileName(ObjectPath)));
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
        public virtual string GetFileAsString(string ObjectPath, bool cleanUp = true)
        {
            byte[] fileAsBinary = GetFileAsBinary(ObjectPath, cleanUp);
            return Encoding.UTF8.GetString(fileAsBinary, 0, fileAsBinary.Length);
        }

        //
        // Parameters:
        //   ObjectPath:
        //
        //   cleanUp:
        public virtual byte[] GetFileAsBinary(string ObjectPath, bool cleanUp = true)
        {
            try
            {
                TemporaryFile fileAsDownloaded = GetFileAsDownloaded(ObjectPath);
                byte[] result = File.ReadAllBytes(fileAsDownloaded.FileFullPath);
                if (cleanUp)
                {
                    fileAsDownloaded.Dispose();
                }

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

        //
        // Parameters:
        //   ObjectPath:
        //
        //   Contents:
        public virtual void SaveFileContent(string ObjectPath, byte[] Contents)
        {
            using TemporaryFile temporaryFile = new();
            File.WriteAllBytes(temporaryFile.FileFullPath, Contents);
            SaveFile(ObjectPath, temporaryFile.FileFullPath);
        }

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
            using BinaryReader binaryReader = new BinaryReader(Contents);
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
}
