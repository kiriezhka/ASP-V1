using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using System.Collections.Specialized;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Routing; // ПИ для маршрутизации
using System.Linq;
using routing;

namespace WebApplication21 // Демо шаблонов маршрутов
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            
            services.AddRouting();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseMiddleware<MyErrorHandling>();
            
            app.Run(async context =>
            {
                
                string path = context.Request.Path;
                if(path.StartsWith("/pages/")) {
                    string lastPath = path.Split('/').Last();
                    context.Response.ContentType= "text/html";
                    await context.Response.SendFileAsync($"wwwroot/{lastPath}.html");
                    
                }
                if(path== "/")
                {
                    context.Response.ContentType= "text/html";
                    await context.Response.SendFileAsync($"wwwroot/home.html");
                }
            });
            var routeBuilder = new RouteBuilder(app);


            
            app.UseRouter(routeBuilder.Build());
            
            
        }
        
    }
}