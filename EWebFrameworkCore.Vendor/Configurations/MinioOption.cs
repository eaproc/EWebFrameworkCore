namespace EWebFrameworkCore.Vendor.Configurations
{
    public class MinioOption
    {
        public string AccessKey { get; set; } = string.Empty;
        public string SecretKey { get; set; } = string.Empty;
        public string Endpoint { get; set; } = string.Empty;
        public bool UseSsl { get; set; } = false;

        /// <summary>
        /// "https://minio.scadware.com:9000", => https://minio.scadware.com
        /// Rewrite port on IIS is not working on save but works on GET.
        /// It will generate | The request signature we calculated does not match the signature you provided. Check your key and signing method.
        /// ------------------------------------
        /// The signature mismatch can indeed happen if there is an IIS rewrite that changes the port from 9000 to 80, 
        /// as the port is part of the request being signed. If the request originally targets port 9000 
        /// but is rewritten to port 80 by IIS, the signature calculated on the client side will not match 
        /// what the MinIO server expects.
        /// ------------------------------------
        /// </summary>
        public string MinioApiEndpointDirectUrl { get => $"http{(UseSsl ? "s" : "")}://{Endpoint.Split(":").First()}"; }
        
        /// <summary>
        /// "https://minio.scadware.com:9000",
        /// </summary>
        public string MinioApiEndpointWithNoRewritePortUrl { get => $"http{(UseSsl ? "s" : "")}://{Endpoint}"; }

        public string MinioApiEndpointDirectUrlWithBucketPath(string bucketPath) => MinioApiEndpointDirectUrl + "/" + bucketPath;
    }
}
