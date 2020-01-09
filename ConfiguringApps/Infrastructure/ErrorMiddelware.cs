using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace ConfiguringApps.Infrastructure
{
    public class ErrorMiddelware
    {
        private RequestDelegate nextDelegate;
        public ErrorMiddelware(RequestDelegate request)
        {
            nextDelegate = request;
        }
        public async Task Invoke(HttpContext httpContext)
        {
            await nextDelegate.Invoke(httpContext);
            if (httpContext.Response.StatusCode == 404)
            {
                await httpContext.Response.WriteAsync("Edge not supported");
            }
            else
            {
                
            }
        }
    }
}
