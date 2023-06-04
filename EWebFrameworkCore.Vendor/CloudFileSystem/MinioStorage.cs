using ELibrary.Standard.VB.Objects;
using EWebFrameworkCore.Vendor.Services;
using Minio;
using Minio.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EWebFrameworkCore.Vendor.CloudFileSystem
{
    //
    // Summary:
    //     Requires installation of Minio nugget https://docs.min.io/docs/dotnet-client-quickstart-guide.html
    public class MinioStorage : FileSystemCompatible
    {
        private readonly MinioClient Minio;

        private readonly string Bucket;

        //
        // Summary:
        //     Create a Minio storage instance
        //
        // Parameters:
        //   Endpoint:
        //     example.com with no protocol
        //
        //   AccessKey:
        //     AccessKey
        //
        //   SecretKey:
        //     SecretKey
        //
        //   Bucket:
        //     Bucket/Folder
        //
        //   SSL:
        //     Use https or http
        public MinioStorage(string Endpoint, string AccessKey, string SecretKey, string Bucket, bool SSL = true)
        {
            MinioClient client = new MinioClient()
                .WithEndpoint(Endpoint)
                .WithCredentials(AccessKey, SecretKey);
            if (SSL)
            {
                client = client.WithSSL();
            }

            Minio = client.Build();

            this.Bucket = Bucket;
        }

        //
        // Summary:
        //     [Minio] MINIO_KEY=svr2FILE2020-.LOC MINIO_SECRET=svr2FILE2020-.LOC MINIO_BUCKET=bucket-name
        //     MINIO_ENDPOINT=example.com:9000 MINIO_USE_SSL=false
        //public static MinioStorage Instance()
        //{
        //    return new MinioStorage(ENV.Minio("MINIO_ENDPOINT"), ENV.Minio("MINIO_KEY"), ENV.Minio("MINIO_SECRET"), ENV.Minio("MINIO_BUCKET"), EBoolean.valueOf(ENV.Minio("MINIO_USE_SSL")));
        //}

        //
        // Summary:
        //     Becareful, if wrong file path is specified, it will return a url to error message.
        //
        // Parameters:
        //   ObjectPath:
        //     FileName - Full relative path to the bucket
        //
        //   Attachment:
        //     If attachment, downloadable else inline disposition
        //
        //   DownloadAsFileName:
        //
        //   ContentType:
        //     Implicate the type of response content type header
        //
        //   ExpiryTimeInSeconds:
        //     Maximum is 604800 - 7 days
        //
        // Returns:
        //     null | string
        public override string CreateTemporaryURL(string ObjectPath, bool Attachment, string DownloadAsFileName, string ContentType, int ExpiryTimeInSeconds)
        {
            try
            {
                Dictionary<string, string> reqParams = new Dictionary<string, string>
                {
                    { "response-content-type", ContentType },
                    {
                        "response-content-disposition",
                        string.Format("{0}{1}", Attachment ? "attachment" : "inline", $"; filename=\"{DownloadAsFileName}\"")
                    }
                };
                return Minio.PresignedGetObjectAsync(new PresignedGetObjectArgs().WithObject(ObjectPath).WithBucket(Bucket).WithExpiry( ExpiryTimeInSeconds ).WithHeaders(reqParams)).Result;
            }
            catch (Exception innerException)
            {
                throw new InvalidOperationException("Unfortunately the url could not be created!", innerException);
            }
        }

        //
        // Summary:
        //     Check if Current Bucket exists
        public override bool StorageExist()
        {
            return Minio.BucketExistsAsync(new BucketExistsArgs().WithBucket(Bucket)).Result;
        }

        //
        // Summary:
        //     Upload file to bucket
        //
        // Parameters:
        //   ObjectPath:
        //
        //   FileFullPath:
        public override void SaveFile(string ObjectPath, string FileFullPath)
        {
            try
            {
                if (StorageExist())
                {
                    Minio.PutObjectAsync(new PutObjectArgs().WithBucket( Bucket ).WithObject(ObjectPath).WithFileName(FileFullPath)).Wait();
                }
            }
            catch (Exception innerException)
            {
                throw new InvalidOperationException("Unfortunately the file could not be uploaded!", innerException);
            }
        }

        //
        // Summary:
        //     Remember to delete file if not needed again
        //
        // Parameters:
        //   ObjectPath:
        public override TemporaryFile GetFileAsDownloaded(string ObjectPath)
        {
            try
            {
                TemporaryFile temporaryFile = new TemporaryFile();
                Minio.GetObjectAsync(new GetObjectArgs().WithBucket( Bucket).WithObject( ObjectPath ).WithFile(temporaryFile.FileFullPath)).Wait();
                return temporaryFile;
            }
            catch (Exception innerException)
            {
                throw new InvalidOperationException("Unfortunately the file could not be downloaded!", innerException);
            }
        }

        //
        // Summary:
        //     Checks if object exists
        //
        // Parameters:
        //   ObjectPath:
        public override bool ObjectExists(string ObjectPath)
        {
            try
            {
                return GetFileInfo(ObjectPath) != null;
            }
            catch (Exception)
            {
                return false;
            }
        }

        //
        // Summary:
        //     Get file details
        //
        // Parameters:
        //   ObjectPath:
        public ObjectStat? GetFileInfo(string ObjectPath)
        {
            try
            {
                return Minio.StatObjectAsync(new StatObjectArgs().WithBucket( Bucket ).WithObject( ObjectPath ) ).Result;
            }
            catch (Exception)
            {
                return null;
            }
        }

        //
        // Summary:
        //     Delete file
        //
        // Parameters:
        //   ObjectPath:
        public override void DeleteObject(string ObjectPath)
        {
            try
            {
                Minio.RemoveObjectAsync(new RemoveObjectArgs().WithBucket(Bucket).WithObject(ObjectPath)).Wait();
            }
            catch (Exception innerException)
            {
                throw new InvalidOperationException("Unfortunately the file could not be deleted!", innerException);
            }
        }
    }
}
