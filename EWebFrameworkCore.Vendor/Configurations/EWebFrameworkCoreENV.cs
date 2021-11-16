using EWebFrameworkCore.Vendor.Middlewares;
using static EWebFrameworkCore.Vendor.Configurations.ConfigurationOptions;

namespace EWebFrameworkCore.Vendor.Configurations
{
    public static class EWebFrameworkCoreENV
    {

        /// <summary>
        /// Returns the APP_URL set in .env file
        /// </summary>
        public static string APP_URL
        {
            get { return CheckServiceProviderMiddleware.Provider.GetEWebFrameworkCoreOptions().GENERAL.APP_URL; }
        }


        /// <summary>
        /// Indicate if app is in Debug mode ( ENVIRONMENT.DEVELOPMENT || APP_DEBUG )
        /// </summary>
        /// <returns></returns>
        public static bool APP_DEBUG
        {
            get {
                var z = CheckServiceProviderMiddleware.Provider.GetEWebFrameworkCoreOptions();
                return z.GetEnvironment() == ENVIRONMENT.DEVELOPMENT || z.GENERAL.APP_DEBUG; 
            }
        }


        /// <summary>
        /// Checks GENERAL:RUNNING_MODE first then ASPNETCORE_ENVIRONMENT
        /// </summary>
        /// <returns></returns>
        public static string RUNNING_MODE
        {
            get{
                return CheckServiceProviderMiddleware.Provider.GetEWebFrameworkCoreOptions().RUNNING_MODE;
            } 
        }

      

    }
  }