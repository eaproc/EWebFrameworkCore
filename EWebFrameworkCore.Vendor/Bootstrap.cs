using EWebFrameworkCore.Vendor.Utils;
using EWebFrameworkCore.Vendor.Configurations;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Serilog;
using Serilog.Core;
using Serilog.Enrichers;
using Serilog.Events;
using Serilog.Sinks.Slack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EWebFrameworkCore.Vendor.Requests;
using Microsoft.Extensions.Hosting;
using System.IO;
using Microsoft.AspNetCore.Builder;

namespace EWebFrameworkCore.Vendor
{
   public static class Bootstrap
    {
        // Static variables are bad in Web App because they will persist accross the app domain
        // if the resource is suppose to be Per Request Scope, don't use STATIC

        //public static IServiceCollection Services { private set; get; }

        /// <summary>
        /// App Wide Domain Serilog Logger
        /// </summary>
        public static Logger Log { private set; get; }

        public static ConfigurationOptions GetEWebFrameworkCoreOptions(this IServiceProvider provider)
        {
            return ((OptionsManager<ConfigurationOptions>)provider.GetService(typeof(IOptionsSnapshot<ConfigurationOptions>))).Value;
        }

        public static WebApplicationBuilder ConfigureEwebFrameworkCoreServices(this WebApplicationBuilder builder)
        {
            builder.Services.AddScoped<IRequestHelper, RequestHelper>();
            //Services = services;

            // Not updating
            //Options = new ConfigurationOptions();
            //configuration.Bind(Options);

            builder.Services.Configure<ConfigurationOptions>(builder.Configuration);



            // https://github.com/serilog/serilog/wiki/Writing-Log-Events
            // Log Event Levels

            // https://github.com/serilog/serilog/wiki/Provided-Sinks
            Log = new LoggerConfiguration()
             .MinimumLevel.Verbose()

            // outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss.fff zzz} [{Level:u3}] {Message:lj} <{ProcessId}><{ThreadId}>{NewLine}{Exception}"
            //.Enrich.WithProcessId()
            //.Enrich.WithThreadId()

            //.Enrich.WithThreadName()
            //.Enrich.WithProperty(ThreadNameEnricher.ThreadNamePropertyName, "MyDefault")
            //.Enrich.FromLogContext()
            // https://github.com/serilog-contrib/serilog-sinks-slack
            //.WriteTo.Slack("https://hooks.slack.com/services/zzzzzzzzzzzzzzzzzzzzz", restrictedToMinimumLevel: LogEventLevel.Error)
            .WriteTo.Console(restrictedToMinimumLevel: Serilog.Events.LogEventLevel.Verbose)
            .WriteTo.File(PathHandlers.AppLogStore("EWebFrameworkCore.Vendor.txt"),
            rollingInterval: RollingInterval.Day, retainedFileCountLimit: 14, restrictedToMinimumLevel: Serilog.Events.LogEventLevel.Warning,
                outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss.fff zzz} [{Level:u3}] {Message:lj} {NewLine}{Exception}"
                )
            .CreateLogger();

            return builder;
        }

        /// <summary>
        /// Place .env file in the app root if you want to load it.
        /// </summary>
        /// <param name="builder"></param>
        /// <returns></returns>
        public static WebApplicationBuilder LoadEnvFile(this WebApplicationBuilder builder)
        {
            string ENVFILE = Vendor.PathHandlers.RootPath(".env");
            if (File.Exists(ENVFILE)) DotNetEnv.Env.Load(ENVFILE);

            return builder;
        }
    }
}
