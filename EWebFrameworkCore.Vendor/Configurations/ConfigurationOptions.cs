﻿namespace EWebFrameworkCore.Vendor.Configurations
{

    // -----------------------------------------------------
    //  In later version, this class can allow dynamic
    //  access to properties that are not strongly typed
    // -----------------------------------------------------

    /// <summary>
    /// It must be properties for it to work
    /// </summary>
    public class ConfigurationOptions
    {
        public enum ENVIRONMENT { UNKNOWN, DEVELOPMENT, PRODUCTION, STAGING }

        public GeneralOption GENERAL { get; set; } = new GeneralOption();
        public LoggingOption LoggingOption { get; set; } = new LoggingOption();
        public MSSQLConnectionOption DATABASE_CONNECTION { get; set; } = new MSSQLConnectionOption();

        public string ASPNETCORE_ENVIRONMENT { get; set; } = "Development";

        /// <summary>
        /// Get application environment
        /// </summary>
        /// <returns></returns>
        public ENVIRONMENT GetEnvironment()
        {
            return ASPNETCORE_ENVIRONMENT.ToUpper() switch
            {
                "DEVELOPMENT" => ENVIRONMENT.DEVELOPMENT,
                "PRODUCTION" => ENVIRONMENT.PRODUCTION,
                "STAGING" => ENVIRONMENT.STAGING,
                _ => ENVIRONMENT.UNKNOWN,
            };
        }
    }
}
