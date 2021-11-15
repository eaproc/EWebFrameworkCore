using EWebFrameworkCore.Vendor.Utils;
using Microsoft.AspNetCore.Mvc;
using Serilog.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EWebFrameworkCore.Vendor
{
    [ApiController]
    public class Controller: ControllerBase
    {
        protected readonly IRequestHelper RequestInputs;
        protected readonly IServiceProvider Provider;
        protected Logger Log { private set; get; }

        public Controller(IServiceProvider Provider)
        {
            this.Provider = Provider;
            this.Log = Bootstrap.Log;
            RequestInputs = (IRequestHelper)Provider.GetService(typeof(IRequestHelper));
        }
    }
}
