using EWebFrameworkCore.Vendor.ConfigurationTypedClasses;
using EWebFrameworkCore.Vendor.Logging;
using EWebFrameworkCore.Vendor.Requests;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using Serilog;
using Serilog.Core;
using Serilog.Events;
using Serilog.Sinks.Slack;
using System.Net;

namespace EWebFrameworkCore.Vendor
{
    public static class Bootstrap
    {
        public const string RawAuthTokenKeyName = "access_token";

        // Static variables are bad in Web App because they will persist accross the app domain
        // if the resource is suppose to be Per Request Scope, don't use STATIC

        //public static IServiceCollection Services { private set; get; }

        /// <summary>
        /// App Wide Domain Serilog Logger
        /// </summary>
        public static Logger? Log { private set; get; }

        public static ConfigurationOptions GetEWebFrameworkCoreOptions(this IServiceProvider provider)
        {
            return provider.GetService(typeof(IOptionsSnapshot<ConfigurationOptions>)) is not OptionsManager<ConfigurationOptions> v ? throw new InvalidProgramException("Please, configure options first in the Service Provider!") : v.Value;
        }

        public static WebApplicationBuilder ConfigureEwebFrameworkCoreServices(this WebApplicationBuilder builder)
        {
            builder.Services.AddScoped<RequestHelper, RequestHelper>();
            //Services = services;

            // Not updating
            //Options = new ConfigurationOptions();
            //configuration.Bind(Options);

            builder.Services.Configure<ConfigurationOptions>(builder.Configuration);

            // https://github.com/serilog/serilog/wiki/Writing-Log-Events
            // Log Event Levels

            // https://github.com/serilog/serilog/wiki/Provided-Sinks
            var c = new LoggerConfiguration()
             .MinimumLevel.Verbose()
            // outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss.fff zzz} [{Level:u3}] {Message:lj} <{ProcessId}><{ThreadId}>{NewLine}{Exception}"
            //.Enrich.WithProcessId()
            //.Enrich.WithThreadId()

            //.Enrich.WithThreadName()
            //.Enrich.WithProperty(ThreadNameEnricher.ThreadNamePropertyName, "MyDefault")
            //.Enrich.FromLogContext()
            // https://github.com/serilog-contrib/serilog-sinks-slack
            .WriteTo.Console(restrictedToMinimumLevel: LogEventLevel.Information)
            .WriteTo.File(PathHandlers.AppLogStore("Background.log"),
                rollingInterval: RollingInterval.Day, retainedFileCountLimit: 14, restrictedToMinimumLevel: LogEventLevel.Information,
                outputTemplate: "{NewLine}{Timestamp:yyyy-MM-dd HH:mm:ss.fff zzz} [{Level:u3}] {Message:lj} {NewLine}{Exception}"
                );

            // https://github.com/serilog-contrib/serilog-sinks-slack
            if (builder.Configuration["Logging:Slack:Enabled"] != null && Convert.ToBoolean(builder.Configuration["Logging:Slack:Enabled"]))
                c.WriteTo.Slack(builder.Configuration["Logging:Slack:Url"], restrictedToMinimumLevel: LogEventLevel.Warning, customChannel: builder.Configuration["Logging:Slack:Channel"], customUsername: builder.Configuration["GENERAL:APP_URL"]);

            Log = c.CreateLogger();




            // Initialize Serilog using the configuration from appsettings.json or other sources
            builder.Host.UseSerilog((hostingContext, services, loggerConfiguration) => {
                loggerConfiguration
                    .MinimumLevel.Verbose()

                    .Enrich.FromLogContext()

                    .WriteTo.Console(restrictedToMinimumLevel: LogEventLevel.Information);

                
                // restrict certain logs if it is production
                if(builder.Environment.IsProduction())
                {
                    loggerConfiguration
                   .MinimumLevel.Override("Microsoft", LogEventLevel.Information) // General override for all Microsoft namespaces
                   .MinimumLevel.Override("Microsoft.AspNetCore.Routing.EndpointMiddleware", LogEventLevel.Warning)
                   .MinimumLevel.Override("Microsoft.AspNetCore.Hosting.Diagnostics", LogEventLevel.Warning)
                   .MinimumLevel.Override("Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker", LogEventLevel.Warning)
                   .MinimumLevel.Override("Microsoft.AspNetCore.Mvc.Infrastructure.ObjectResultExecutor", LogEventLevel.Warning);
                }


                // Files
                if (hostingContext.Configuration.GetValue<bool>("Logging:File:Enabled"))
                {
                    // Seq
                    loggerConfiguration.WriteTo.File(new SerilogPrettyJsonFormatter(), PathHandlers.AppLogStore("Verbose.EWebFrameworkCore.json"),
                        rollingInterval: RollingInterval.Day, retainedFileCountLimit: 2,
                        restrictedToMinimumLevel: LogEventLevel.Verbose
                    );

                    loggerConfiguration.WriteTo.File(PathHandlers.AppLogStore("Information.EWebFrameworkCore.log"),
                        rollingInterval: RollingInterval.Day, retainedFileCountLimit: 6,
                        restrictedToMinimumLevel: LogEventLevel.Information,
                        outputTemplate: "{NewLine}{Timestamp:yyyy-MM-dd HH:mm:ss.fff zzz} [{Level:u3}] {Message:lj} {NewLine}{Exception}"
                        );

                    loggerConfiguration.WriteTo.File(PathHandlers.AppLogStore("Warning.EWebFrameworkCore.log"),
                        rollingInterval: RollingInterval.Day, retainedFileCountLimit: 14,
                        restrictedToMinimumLevel: LogEventLevel.Warning,
                        outputTemplate: "{NewLine}{Timestamp:yyyy-MM-dd HH:mm:ss.fff zzz} [{Level:u3}] {Message:lj} {NewLine}{Exception}"
                        );
                }

                // Adding Slack logging based on configuration settings
                if (hostingContext.Configuration.GetValue<bool>("Logging:Slack:Enabled"))
                {
                    loggerConfiguration.WriteTo.Slack(
                        hostingContext.Configuration["Logging:Slack:Url"],
                        restrictedToMinimumLevel: Serilog.Events.LogEventLevel.Warning,
                        customChannel: hostingContext.Configuration["Logging:Slack:Channel"],
                        customUsername: hostingContext.Configuration["GENERAL:APP_URL"]
                    );
                }

                // Adding SEQ logging based on configuration settings
                if (hostingContext.Configuration.GetValue<bool>("Logging:Seq:Enabled"))
                {
                    // Seq
                    loggerConfiguration
                     .WriteTo.Seq(
                         restrictedToMinimumLevel: LogEventLevel.Information,
                         serverUrl: builder.Configuration["Logging:Seq:ServerUrl"],
                         apiKey: builder.Configuration["Logging:Seq:Token"]
                     );  // URL for your Seq instance
                }
            });

            return builder;
        }

        public static ConfigurationOptions ConfigurationOptions(this HttpContext httpContext)
        {
            return httpContext.RequestServices.GetEWebFrameworkCoreOptions();
        }

        public static bool IsAppInDebugMode(this HttpContext httpContext)
        {
            return httpContext.ConfigurationOptions().GENERAL.APP_DEBUG;
        }
              
        public static ConfigurationOptions.ENVIRONMENT GetAppEnvironment(this HttpContext httpContext)
        {
            return httpContext.ConfigurationOptions().GetEnvironment();
        }

        public static bool IsInDevelopmentEnvironment(this HttpContext httpContext)
        {
            return httpContext.GetAppEnvironment() == ConfigurationTypedClasses.ConfigurationOptions.ENVIRONMENT.DEVELOPMENT;
        }
        
        public static bool IsInProductionEnvironment(this HttpContext httpContext)
        {
            return httpContext.GetAppEnvironment() == ConfigurationTypedClasses.ConfigurationOptions.ENVIRONMENT.PRODUCTION;
        }        

        public static Logger Logger(this HttpContext _)
        {
            return GetLogger();
        }

        public static Logger GetLogger()
        {
            return Log ?? throw new InvalidProgramException("Logger is not configured!");
        }

        public static Logger ReportException(this Logger logger, Exception exception, string? customTitle = null)
        {
            logger.Error(exception, messageTemplate: customTitle?? exception.Message );
            return logger;
        }

        public static Logger ReportRestResponse(this Logger logger, HttpStatusCode StatusCode, string? ResponseContent,  string? customTitle = null)
        {
            logger.Error( (customTitle ?? "Error Executing Rest Request." ) + $" | Content: {ResponseContent} | Status Code: {StatusCode}");
            return logger;
        }

        public static RequestHelper GetRequestHelper(this IServiceProvider provider)
        {
            return provider.GetService(typeof(RequestHelper)) as RequestHelper ?? throw new InvalidOperationException("It seems we can not initialize RequestHelper service");
        }   
        
        public static IConfiguration GetConfigurations(this IServiceProvider provider)
        {
            return provider.GetService<IConfiguration>() ?? throw new InvalidOperationException("It seems we can not initialize IConfiguration service"); ;
        }   
        
        public static HttpContext GetHttpContext(this IServiceProvider provider)
        {
            IHttpContextAccessor httpContextAccessor = provider.GetService<IHttpContextAccessor>() ?? throw new InvalidOperationException("IHttpContextAccessor: Services must be used via http request calls. All depends on HttpContext!");
            return httpContextAccessor.GetHttpContext();
        }
        
        public static HttpContext GetHttpContext(this IHttpContextAccessor httpContextAccessor)
        {
            return httpContextAccessor.HttpContext ?? throw new InvalidOperationException("HttpContext: Services must be used via http request calls. All depends on HttpContext!");
        }

        ///// <summary>
        ///// @deprecated
        ///// Place .env file in the app root if you want to load it.
        ///// </summary>
        ///// <param name="builder"></param>
        ///// <returns></returns>
        //[Obsolete("Not using .env file any more for .NET Core Apps")]
        //public static WebApplicationBuilder LoadEnvFile(this WebApplicationBuilder builder)
        //{
        //    //string ENVFILE = Vendor.PathHandlers.RootPath(".env");
        //    //if (File.Exists(ENVFILE)) DotNetEnv.Env.Load(ENVFILE);

        //    return builder;
        //}
    }
}
