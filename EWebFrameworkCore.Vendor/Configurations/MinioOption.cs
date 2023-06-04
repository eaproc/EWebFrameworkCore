namespace EWebFrameworkCore.Vendor.Configurations
{
    public class MinioOption
    {
        public string AccessKey { get; set; } = string.Empty;
        public string SecretKey { get; set; } = string.Empty;
        public string Endpoint { get; set; } = string.Empty;
        public bool UseSsl { get; set; } = false;

    }
}
