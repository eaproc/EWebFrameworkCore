using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace EWebFrameworkCore.Vendor.Requests
{
    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class RequestsExtensions
    {
        public static string SaveFormFileAs(this IFormFile formFile, string FileFullPath)
        {
            if (!Directory.Exists(Path.GetDirectoryName(FileFullPath))) Directory.CreateDirectory(Path.GetDirectoryName(FileFullPath)?? throw new Exception("Invalid File Path"));
            using( var f = new FileStream(FileFullPath, FileMode.Create))
            {
                formFile.CopyTo(f);
            }
            return FileFullPath;
        }
    }
}
