using EWebFrameworkCore.Vendor.Utils;
using EWebFrameworkCore.Vendor.Configurations;
using Microsoft.AspNetCore.Mvc;
using Serilog.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EWebFrameworkCore.Vendor.Requests;

namespace EWebFrameworkCore.Vendor
{
    [ApiController]
    public class Controller: ControllerBase
    {
        protected readonly IRequestHelper RequestInputs;
        protected readonly IServiceProvider Provider;
        protected readonly ConfigurationOptions EWebFrameworkCoreConfigurations;

        public MSSQLConnectionOption DEFAULT_MSSQL { get; }

        protected Logger Log { private set; get; }

        public Controller(IServiceProvider Provider)
        {
            this.EWebFrameworkCoreConfigurations = Provider.GetEWebFrameworkCoreOptions();
            this.DEFAULT_MSSQL = EWebFrameworkCoreConfigurations.DATABASE_CONNECTION;
            this.Provider = Provider;
            this.Log = Bootstrap.Log;
            RequestInputs = (IRequestHelper)Provider.GetService(typeof(IRequestHelper));
        }
    }
}
