using EWebFrameworkCore.Vendor.ConfigurationTypedClasses;
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

        /// <summary>
        /// https://anthonygiretti.com/2021/05/01/c-make-your-delegates-asynchronous-from-synchronous-delegates/
        /// </summary>
        /// <param name="action"></param>
        /// <param name="TaskIdentifier"></param>
        /// <param name="delayInMilliseconds"></param>
        public static async void RunAfterResponse(Func<Task> action, string TaskIdentifier, int delayInMilliseconds = 2000)
        {
            // Example
            //RunAfterResponse(async () =>
            //{
            //    await Task.Run(() =>
            //    {
            //        Console.WriteLine("About to run!");
            //        // Task.Delay(15000); // this will not work. If you need to run awaitable task, change the delegate to async
            //        using var scope = serviceScopeFactory.CreateScope();
            //        Console.WriteLine("After 5secs Done with work!");
            //    });
            //}, "Testing", 5000);

            // Example with functional delay inside
            //RunAfterResponse(async () =>
            //{
            //    await Task.Run( async () =>
            //    {
            //        Console.WriteLine("About to run!");
            //        await Task.Delay(15000); 
            //        using var scope = serviceScopeFactory.CreateScope();
            //        Console.WriteLine("After 5secs Done with work!");
            //    });
            //}, "Testing", 5000);

            await Task.Run(async () =>
            {
                try
                {
                    //Tested for 15 minutes and was fine
                    await Task.Delay(delayInMilliseconds);
                    await action();
                }
                catch (Exception e)
                {
                    Bootstrap.GetLogger().ReportException(e, $"Error occurred while running background task. [{TaskIdentifier}]");
                }
            });
        }
    }
}
