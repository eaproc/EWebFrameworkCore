namespace EWebFrameworkCore.Vendor.Exceptions
{
    public class InvalidChunkFileUploadException : Exception
    {
        public InvalidChunkFileUploadException(string uuid) : base($"{uuid}: Invalid File Upload Detected!") { }
    }
}
