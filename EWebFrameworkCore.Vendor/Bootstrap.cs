using EWebFrameworkCore.Vendor.ConfigurationTypedClasses;
using EWebFrameworkCore.Vendor.Requests;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Serilog;
using Serilog.Core;
using Serilog.Events;
using Serilog.Sinks.Slack;

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
            .WriteTo.Console(restrictedToMinimumLevel: LogEventLevel.Verbose)
            .WriteTo.File(PathHandlers.AppLogStore("EWebFrameworkCore.Vendor.txt"),
                rollingInterval: RollingInterval.Day, retainedFileCountLimit: 14, restrictedToMinimumLevel: LogEventLevel.Warning,
                outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss.fff zzz} [{Level:u3}] {Message:lj} {NewLine}{Exception}"
                );

            // https://github.com/serilog-contrib/serilog-sinks-slack
            if (builder.Configuration["Logging:Slack:Enabled"] != null && Convert.ToBoolean(builder.Configuration["Logging:Slack:Enabled"]))
                c.WriteTo.Slack(builder.Configuration["Logging:Slack:Url"], restrictedToMinimumLevel: LogEventLevel.Warning, customChannel: builder.Configuration["Logging:Slack:Channel"], customUsername: builder.Configuration["GENERAL:APP_URL"]);

            Log = c.CreateLogger();

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
