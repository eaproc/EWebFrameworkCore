using EWebFrameworkCore.Vendor;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace EWebFrameworkCore.Dev
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).LoadEnvFile().Build()
                .Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) {
            return  Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
        }
    }
}
