using EWebFrameworkCore.Vendor.ConfigurationTypedClasses;
using EWebFrameworkCore.Vendor.Requests;
using Microsoft.AspNetCore.Http;

namespace EWebFrameworkCore.Vendor.Services
{
    /// <summary>
    /// Extend for Client Service
    /// </summary>
    public class BaseClientService : JobCompatibleService
    {
        public HttpContext HttpContext { get; }

        protected readonly RequestHelper RequestInputs;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="provider"></param>
        /// <param name="connectionOption"></param>
        /// <exception cref="InvalidOperationException"></exception>
        public BaseClientService(IServiceProvider provider, MSSQLConnectionOption connectionOption): base(provider: provider, connectionOption: connectionOption)
        {
            RequestInputs = provider.GetRequestHelper();
            HttpContext = provider.GetHttpContext();
        }

        public BaseClientService(IServiceProvider provider) : this(provider, new MSSQLConnectionOption())
        { }
    }
}