using EWebFrameworkCore.Vendor.ConfigurationTypedClasses;
using EWebFrameworkCore.Vendor.Controllers;
using EWebFrameworkCore.Vendor.Logging;
using EWebFrameworkCore.Vendor.Requests;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Serilog;
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
        public static Serilog.ILogger? AsyncNoServiceProviderLogger { private set; get; }

        public static ConfigurationOptions GetEWebFrameworkCoreOptions(this IServiceProvider provider)
        {
            return provider.GetService(typeof(IOptionsSnapshot<ConfigurationOptions>)) is not OptionsManager<ConfigurationOptions> v ? throw new InvalidProgramException("Please, configure options first in the Service Provider!") : v.Value;
        }

        public static WebApplicationBuilder ConfigureEwebFrameworkCoreServices(this WebApplicationBuilder builder)
        {
            builder.Services.AddScoped<RequestHelper, RequestHelper>();
            builder.Services.AddHttpClient();
            //Services = services;

            // Not updating
            //Options = new ConfigurationOptions();
            //configuration.Bind(Options);

            builder.Services.Configure<ConfigurationOptions>(builder.Configuration);

            CreateAsyncNoServiceProviderLogger();

            // Initialize Serilog using the configuration from appsettings.json or other sources
            builder.Host.UseSerilog((hostingContext, services, loggerConfiguration) =>
            {
                CreateScopedILoggerSerilog(builder, hostingContext, loggerConfiguration);
            });


            // Add controllers from the 'This library' 
            builder.Services.AddControllers()
                .AddApplicationPart(typeof(LogViewerController).Assembly);


            return builder;
        }

        private static void CreateScopedILoggerSerilog(WebApplicationBuilder builder, HostBuilderContext hostingContext, LoggerConfiguration loggerConfiguration)
        {
            // Set base logging level and enrich the log context for better correlation
            loggerConfiguration
                .MinimumLevel.Verbose()
                .Enrich.FromLogContext()
                .WriteTo.Async(a => a.Console(restrictedToMinimumLevel: LogEventLevel.Information)); // Use async wrapper for non-blocking logging to console

            // Apply different log levels for production environment to reduce log verbosity
            if (builder.Environment.IsProduction())
            {
                loggerConfiguration
                    .MinimumLevel.Override("Microsoft", LogEventLevel.Information) // General override for Microsoft logs
                    .MinimumLevel.Override("Microsoft.AspNetCore.Routing.EndpointMiddleware", LogEventLevel.Warning)
                    .MinimumLevel.Override("Microsoft.AspNetCore.Hosting.Diagnostics", LogEventLevel.Warning)
                    .MinimumLevel.Override("Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker", LogEventLevel.Warning)
                    .MinimumLevel.Override("Microsoft.AspNetCore.Mvc.Infrastructure.ObjectResultExecutor", LogEventLevel.Warning)
                    .MinimumLevel.Override("Microsoft.AspNetCore.Cors.Infrastructure.CorsService", LogEventLevel.Warning) // Added override for CORS service
                    .MinimumLevel.Override("Microsoft.AspNetCore.Mvc.Infrastructure.RedirectResultExecutor", LogEventLevel.Warning); // Added override for redirect result executor
            }

            // Add file logging if enabled in configuration
            if (hostingContext.Configuration.GetValue<bool>("Logging:File:Enabled"))
            {
                //// Verbose logs with JSON formatting (e.g., for structured logging)
                //loggerConfiguration.WriteTo.Async(a => a.File(
                //    new SerilogPrettyJsonFormatter(),
                //    PathHandlers.AppLogStore("Verbose.EWebCore.json"),
                //    rollingInterval: RollingInterval.Day,
                //    retainedFileCountLimit: 2,
                //    restrictedToMinimumLevel: LogEventLevel.Verbose
                //));

                // Verbose logs with JSON formatting (e.g., for structured logging)
                loggerConfiguration.WriteTo.Async(a => a.File(
                    PathHandlers.AppLogStore("Verbose.EWebCore.json"),
                    rollingInterval: RollingInterval.Day,
                    retainedFileCountLimit: 2,
                    restrictedToMinimumLevel: LogEventLevel.Verbose,
                    outputTemplate: "{NewLine}{Timestamp:yyyy-MM-dd HH:mm:ss.fff zzz} [{Level:u3}] {Message:lj} {NewLine}{Exception}"
                ));

                // Information-level logs with a specific text template
                loggerConfiguration.WriteTo.Async(a => a.File(
                    PathHandlers.AppLogStore("Inf.EWebCore.log"),
                    rollingInterval: RollingInterval.Day,
                    retainedFileCountLimit: 6,
                    restrictedToMinimumLevel: LogEventLevel.Information,
                    outputTemplate: "{NewLine}{Timestamp:yyyy-MM-dd HH:mm:ss.fff zzz} [{Level:u3}] {Message:lj} {NewLine}{Exception}"
                ));

                // Warning-level logs with a longer retention period
                loggerConfiguration.WriteTo.Async(a => a.File(
                    PathHandlers.AppLogStore("Wrn.EWebCore.log"),
                    rollingInterval: RollingInterval.Day,
                    retainedFileCountLimit: 14,
                    restrictedToMinimumLevel: LogEventLevel.Warning,
                    outputTemplate: "{NewLine}{Timestamp:yyyy-MM-dd HH:mm:ss.fff zzz} [{Level:u3}] {Message:lj} {NewLine}{Exception}"
                ));
            }

            // Add Slack logging for warnings and above if enabled in configuration
            if (hostingContext.Configuration.GetValue<bool>("Logging:Slack:Enabled"))
            {
                loggerConfiguration.WriteTo.Slack(
                    hostingContext.Configuration["Logging:Slack:Url"],
                    restrictedToMinimumLevel: LogEventLevel.Warning,
                    customChannel: hostingContext.Configuration["Logging:Slack:Channel"],
                    customUsername: hostingContext.Configuration["GENERAL:APP_URL"]
                );
            }

            // Add Seq logging for structured log management if enabled in configuration
            if (hostingContext.Configuration.GetValue<bool>("Logging:Seq:Enabled"))
            {
                // Use async wrapper for Seq logging to offload it to a background thread
                loggerConfiguration.WriteTo.Async(a => a.Seq(
                    serverUrl: builder.Configuration["Logging:Seq:ServerUrl"],
                    apiKey: builder.Configuration["Logging:Seq:Token"],
                    restrictedToMinimumLevel: LogEventLevel.Information
                ));
            }
        }

        private static void CreateAsyncNoServiceProviderLogger()
        {
            // Creating an async logger configuration to avoid blocking the main thread
            var asyncNoServiceProviderLoggerLoggerConfiguration = new LoggerConfiguration()
                .MinimumLevel.Verbose()

                // Adding async wrapper to the sinks to make logging non-blocking
                .WriteTo.Async(a => a.File(
                    PathHandlers.AppLogStore("AsyncBackend.log"),
                    rollingInterval: RollingInterval.Day,
                    retainedFileCountLimit: 14,
                    restrictedToMinimumLevel: LogEventLevel.Information,
                    outputTemplate: "{NewLine}{Timestamp:yyyy-MM-dd HH:mm:ss.fff zzz} [{Level:u3}] {Message:lj} {NewLine}{Exception}"
                ));

            // Create the logger
            AsyncNoServiceProviderLogger = asyncNoServiceProviderLoggerLoggerConfiguration.CreateLogger();
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

        public static Serilog.ILogger GetAsyncNoServiceProviderLogger()
        {
            return AsyncNoServiceProviderLogger ?? throw new InvalidProgramException("Logger is not configured!");
        }

        public static ILogger<T> CreateLoggerFromFactory<T>(this IServiceProvider provider)
        {
            return provider.GetRequiredService<ILoggerFactory>().CreateLogger<T>();
        }

        public static ILogger<T> ReportException<T>(this ILogger<T> logger, Exception exception, string? customTitle = null)
        {
            logger.LogError(exception, customTitle?? exception.Message );
            return logger;
        }

        public static ILogger<T> ReportRestResponse<T>(this ILogger<T> logger, HttpStatusCode StatusCode, string? ResponseContent,  string? customTitle = null)
        {
            logger.LogError( (customTitle ?? "Error Executing Rest Request." ) + $" | Content: {ResponseContent} | Status Code: {StatusCode}");
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
