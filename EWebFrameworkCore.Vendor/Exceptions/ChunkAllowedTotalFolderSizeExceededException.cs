namespace EWebFrameworkCore.Vendor.Exceptions
{
    public class ChunkAllowedTotalFolderSizeExceededException : Exception
    {
        public ChunkAllowedTotalFolderSizeExceededException(string uuid, long chunkSizeInByte, long currentUsageSizeInBytes, long allowedStorageSizeInKb) : 
            base($"{uuid}: The chunk of size {chunkSizeInByte} bytes will cause the allowed storage to exceed {allowedStorageSizeInKb} kb! Current Usage Size: {currentUsageSizeInBytes} bytes.") { }
    }
}
