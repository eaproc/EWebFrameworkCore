using System.Text.Json.Serialization;

namespace EWebFrameworkCore.Vendor.Configurations
{
    public class JWTOption
    {
        [JsonPropertyName("ValidAudience")]
        public string ValidAudience { get; set; } = string.Empty;

        [JsonPropertyName("ValidIssuer")]
        public string ValidIssuer { get; set; } = string.Empty;

        [JsonPropertyName("ExpiresInMinutes")]
        public int ExpiresInMinutes { get; set; } = 60;

        [JsonPropertyName("Secret")] public string Secret { get; set; } = string.Empty;
    }
}
