using EWebFrameworkCore.Vendor.Utils;
using Microsoft.Extensions.DependencyInjection;
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

namespace EWebFrameworkCore.Vendor
{
   public static class Bootstrap
    {
        public static IServiceCollection Services { private set; get; }
        public static Logger Log { private set; get; }

        public static IServiceCollection ConfigureEwebFrameworkCoreServices(this IServiceCollection services)
        {
            services.AddScoped<IRequestHelper, RequestHelper>();
            Services = services;

            // https://github.com/serilog/serilog/wiki/Writing-Log-Events
            // Log Event Levels

            // https://github.com/serilog/serilog/wiki/Provided-Sinks
            Log = new LoggerConfiguration()
             .MinimumLevel.Verbose()
             .Enrich.WithProcessId()
             .Enrich.WithThreadId()
            //.Enrich.WithThreadName()
            //.Enrich.WithProperty(ThreadNameEnricher.ThreadNamePropertyName, "MyDefault")
            //.Enrich.FromLogContext()
            // https://github.com/serilog-contrib/serilog-sinks-slack
            //.WriteTo.Slack("https://hooks.slack.com/services/zzzzzzzzzzzzzzzzzzzzz", restrictedToMinimumLevel: LogEventLevel.Error)
            .WriteTo.Console(restrictedToMinimumLevel: Serilog.Events.LogEventLevel.Verbose)
            .WriteTo.File("Storage/Logs/EWebFrameworkCore.Vendor.txt", rollingInterval: RollingInterval.Day, retainedFileCountLimit: 14, restrictedToMinimumLevel: Serilog.Events.LogEventLevel.Warning,
                outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss.fff zzz} [{Level:u3}] {Message:lj} <{ProcessId}><{ThreadId}>{NewLine}{Exception}"
                )
            .CreateLogger();

            return services;
        }


    }
}
