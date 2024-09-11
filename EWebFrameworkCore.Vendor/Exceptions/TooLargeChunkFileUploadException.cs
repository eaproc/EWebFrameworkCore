namespace EWebFrameworkCore.Vendor
{
    public class TooLargeChunkFileUploadException : Exception
    {
        public TooLargeChunkFileUploadException(string uuid, long uploadedSizeBytes, long limitSizeBytes): 
            base($"{uuid}: Excessive File Size Detected! ExpectedBytes: {limitSizeBytes}, UploadedBytes: {uploadedSizeBytes}" ) { }
    }
}
