﻿namespace EWebFrameworkCore.Vendor.Configurations
{
    public class GeneralOption
    {
        /// <summary>
        /// Returns true if it is Development Environment
        /// </summary>
        public bool APP_DEBUG { get; set; }
        public bool REDIRECT_HTTPS { get; set; }
        public bool REDIRECT_WWW { get; set; }
        public string? DATABASE_TIMEZONE { get; set; }
        public string APP_URL { get; set; } = string.Empty;

        /// <summary>
        /// # All apps should have this for secure connection
        /// # This is the app security door for inbound connections
        /// </summary>
        public List<string> ALLOWED_API_IPS { get; set; } = new List<string>();
        public List<string> AllowedGuestApiTokens { get; set; } = new List<string>();

        /// <summary>
        /// # This is just use for decryption of secure data (like password)
        /// # over the communication channel. It doesnt have to be unique
        /// # per app. All app can use one single key
        /// </summary>
        public string? SHARP_LARAVEL_KEY { get; set; }

    }
}
