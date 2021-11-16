using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;

namespace EWebFrameworkCore.Vendor.Middlewares
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class CheckServiceProviderMiddleware
    {
        private readonly RequestDelegate _next;

        public static IServiceProvider Provider { private set; get; }

        public CheckServiceProviderMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public Task Invoke(HttpContext httpContext)
        {
            Provider = httpContext.RequestServices;
            return _next(httpContext);
        }
    }
}
