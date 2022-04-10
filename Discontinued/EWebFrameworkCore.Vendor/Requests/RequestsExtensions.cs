using ELibrary.Standard.VB;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace EWebFrameworkCore.Vendor.Requests
{
    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class RequestsExtensions
    {
        public static string SaveFormFileAs(this IFormFile formFile, string FileFullPath)
        {
            if (!Directory.Exists(Path.GetDirectoryName(FileFullPath))) Directory.CreateDirectory(Path.GetDirectoryName(FileFullPath));
            using( var f = new FileStream(FileFullPath, FileMode.Create))
            {
                formFile.CopyTo(f);
            }
            return FileFullPath;
        }
    }
}
