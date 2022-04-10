using EWebFrameworkCore.Vendor;
using EWebFrameworkCore.Vendor.Middlewares;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace EWebFrameworkCore.Dev
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;

            //configuration.GetSection("TopItem:Month").Get<TopItemSettings>()

            // https://docs.microsoft.com/en-us/aspnet/core/fundamentals/configuration/options?view=aspnetcore-5.0
            // For Singleton, does not read updated configuration
            // services.Configure<PositionOptions>(Configuration.GetSection(PositionOptions.Position));
            //
            // Can now be accessed from constructor or ServiceProvider as
            // Is registered as a Singleton and can be injected into any service lifetime.
            // IOptions<PositionOptions> options

            // Singleton but reads updated
            // IOptionsMonitor<TOptions>:

            // Is useful in scenarios where options should be recomputed on every request. | SCOPED
            // Reads updated
            // IOptionsSnapshot<TOptions>:



        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddHttpContextAccessor();

            services.ConfigureEwebFrameworkCoreServices( this.Configuration );

            //// Configure Database
            //services.AddScoped<DBEntities.IClientService>((provider) => new DBEntities.ClientService(provider.GetEWebFrameworkCoreOptions().DATABASE_CONNECTION)); ;

            services.AddAuthorization();

            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.ConfigureEWebFrameworkCoreMiddlewares();

            app.UseRouting();

            app.UseAuthentication();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
