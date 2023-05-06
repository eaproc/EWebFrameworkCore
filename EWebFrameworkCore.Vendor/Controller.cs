using EWebFrameworkCore.Vendor.Configurations;
using EWebFrameworkCore.Vendor.Requests;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Serilog.Core;

namespace EWebFrameworkCore.Vendor
{
    [ApiController]
    public class Controller: ControllerBase
    {
        protected readonly IRequestHelper RequestInputs;

        protected RequestValidator InputValidator { get; }

        protected readonly IServiceProvider Provider;
        protected readonly ConfigurationOptions EWebFrameworkCoreConfigurations;
        public IConfiguration Configurations { get; private set; }

        public MSSQLConnectionOption DEFAULT_MSSQL { get; }

        protected Logger Log { private set; get; }

        public Controller(IServiceProvider Provider)
        {
            this.EWebFrameworkCoreConfigurations = Provider.GetEWebFrameworkCoreOptions();
            this.Configurations = Provider.GetService<IConfiguration>()?? throw new InvalidOperationException("It seems we can not initialize IConfiguration service");

            this.DEFAULT_MSSQL = EWebFrameworkCoreConfigurations.DATABASE_CONNECTION;
            this.Provider = Provider;
            this.Log = HttpContext.Logger();
            RequestInputs = Provider.GetService(typeof(IRequestHelper)) as IRequestHelper?? throw new InvalidOperationException("It seems we can not initialize IRequestHelper service");
            InputValidator = new RequestValidator(RequestInputs);
        }
    }
}
