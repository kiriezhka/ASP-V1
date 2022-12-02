using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;
using System;

namespace routing
{
    public class MyErrorHandling
    {
        private readonly RequestDelegate _next;

        public MyErrorHandling(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next.Invoke(context);
            }
            catch (Exception e)
            {
                context.Response.StatusCode = 404;
                
                
            }
        }
    }
}
