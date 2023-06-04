using EWebFrameworkCore.Vendor.Configurations;
using EWebFrameworkCore.Vendor.Requests;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Serilog.Core;

namespace EWebFrameworkCore.Vendor
{
    [ApiController]
    public class Controller: ControllerBase
    {
        protected readonly RequestHelper RequestInputs;

        protected RequestValidator InputValidator { get; }

        protected readonly IServiceProvider Provider;
        protected readonly ConfigurationOptions EWebFrameworkCoreConfigurations;
        public IConfiguration Configurations { get; private set; }

        public MSSQLConnectionOption DEFAULT_MSSQL { get; }

        protected Logger Log { private set; get; }

        public Controller(IServiceProvider Provider)
        {
            this.EWebFrameworkCoreConfigurations = Provider.GetEWebFrameworkCoreOptions();
            this.Configurations = Provider.GetConfigurations();

            this.DEFAULT_MSSQL = EWebFrameworkCoreConfigurations.DATABASE_CONNECTION;
            this.Provider = Provider;
            this.Log = HttpContext.Logger();
            RequestInputs = Provider.GetRequestHelper();
            InputValidator = new RequestValidator(RequestInputs);
        }
    }
}
