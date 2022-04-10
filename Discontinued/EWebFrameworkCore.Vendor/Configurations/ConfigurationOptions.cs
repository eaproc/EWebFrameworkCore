using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EWebFrameworkCore.Vendor.Configurations
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
        public MSSQLConnectionOption DATABASE_CONNECTION { get; set; } = new MSSQLConnectionOption();

        public string ASPNETCORE_ENVIRONMENT { get; set; } = "Development";
        public string TEST_ME { get; set; } 

        public string Default { get; set; } = string.Empty;
        public string Microsoft { get; set; }



        /// <summary>
        /// Checks GENERAL:RUNNING_MODE first then ASPNETCORE_ENVIRONMENT
        /// </summary>
        /// <returns></returns>
        public  string RUNNING_MODE
        {
            get
            {
                return GENERAL.RUNNING_MODE ?? ASPNETCORE_ENVIRONMENT;
            }
        }

        /// <summary>
        /// Get application environment
        /// </summary>
        /// <returns></returns>
        public ENVIRONMENT GetEnvironment()
        {
            switch (RUNNING_MODE.ToUpper())
            {
                case "DEVELOPMENT":
                    return ENVIRONMENT.DEVELOPMENT;
                case "PRODUCTION":
                    return ENVIRONMENT.PRODUCTION;
                case "STAGING":
                    return ENVIRONMENT.STAGING;
                default:
                    return ENVIRONMENT.UNKNOWN;
            }
        }
    }
}
