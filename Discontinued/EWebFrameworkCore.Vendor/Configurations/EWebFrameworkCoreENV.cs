using EWebFrameworkCore.Vendor.Middlewares;
using System;
using static EWebFrameworkCore.Vendor.Configurations.ConfigurationOptions;

namespace EWebFrameworkCore.Vendor.Configurations
{
    public class EWebFrameworkCoreENV
    {
        public EWebFrameworkCoreENV(IServiceProvider ServiceProvider)
        {
            this.ServiceProvider = ServiceProvider;
        }

        /// <summary>
        /// Returns the APP_URL set in .env file
        /// </summary>
        public string APP_URL
        {
            get { return ServiceProvider.GetEWebFrameworkCoreOptions().GENERAL.APP_URL; }
        }


        /// <summary>
        /// Indicate if app is in Debug mode ( ENVIRONMENT.DEVELOPMENT || APP_DEBUG )
        /// </summary>
        /// <returns></returns>
        public  bool APP_DEBUG
        {
            get {
                var z = ServiceProvider.GetEWebFrameworkCoreOptions();
                return z.GetEnvironment() == ENVIRONMENT.DEVELOPMENT || z.GENERAL.APP_DEBUG; 
            }
        }


        /// <summary>
        /// Checks GENERAL:RUNNING_MODE first then ASPNETCORE_ENVIRONMENT
        /// </summary>
        /// <returns></returns>
        public  string RUNNING_MODE
        {
            get{
                return ServiceProvider.GetEWebFrameworkCoreOptions().RUNNING_MODE;
            } 
        }

        public IServiceProvider ServiceProvider { get; }
    }
  }