using ELibrary.Standard.VB;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MimeMapping;

namespace EWebFrameworkCore.Vendor.Responses
{
    public class FileResponseHelper
    {
        private readonly HttpContext _httpContext;
        public FileResponseHelper(HttpContext httpContext) {
            _httpContext = httpContext;
        }

        public IActionResult ReturnFileResponse(string filePath, string mimeType, string downloadName, Action? onCompleted = null)
        {
            if (!File.Exists(filePath))
            {
                return new NotFoundResult();
            }
            
            try
            {
                var fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read, bufferSize: 4096, useAsync: true);
                var result = new FileStreamResult(fileStream, mimeType)
                {
                    FileDownloadName = downloadName
                };

                result.FileStream.Position = 0;  // Ensure the stream starts at the beginning
                result.FileStream.Close();

                // Register a callback to delete the file once the response is completed
                _httpContext.Response.OnCompleted(() =>
                {
                    fileStream.Dispose();
                    onCompleted?.Invoke();
                    return Task.CompletedTask;
                });

                return result;
            }
            catch (Exception)
            {
                //logger?.LogError(ex, $"Error serving file: {filePath}");
                return new StatusCodeResult(500);
            }
        }

        public IActionResult ReturnFileResponse(string filePath, string downloadName, Action? onCompleted = null)
        {
            return ReturnFileResponse(filePath, MimeUtility.GetMimeMapping(downloadName), downloadName, onCompleted);
        }

        public IActionResult ReturnFileResponse(string filePath, Action? onCompleted = null)
        {
            return ReturnFileResponse(filePath, downloadName: EIO.GetFileName(filePath), onCompleted: onCompleted);
        }
    }
}
