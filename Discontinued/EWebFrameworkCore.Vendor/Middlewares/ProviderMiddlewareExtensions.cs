using Microsoft.AspNetCore.Builder;

namespace EWebFrameworkCore.Vendor.Middlewares
{
    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class ProviderMiddlewareExtensions
    {
        public static IApplicationBuilder ConfigureEWebFrameworkCoreMiddlewares(this IApplicationBuilder builder)
        {
            return builder;
            //return builder.UseMiddleware<CheckServiceProviderMiddleware>();
        }
    }
}
