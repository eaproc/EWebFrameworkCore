using EWebFrameworkCore.Vendor.Middlewares;
using System;
using static EWebFrameworkCore.Vendor.ConfigurationTypedClasses.ConfigurationOptions;

namespace EWebFrameworkCore.Vendor.ConfigurationTypedClasses
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
                return  z.GENERAL.APP_DEBUG; 
            }
        }


        public IServiceProvider ServiceProvider { get; }
    }
  }