using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace EmployeeManagement
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        //ByDefault VS uses iisexpress to host and run application
        //iisexpress=it is a lightweight self contained version of iis optimised specially for developing app
        //iisexpress is not used in production
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
			 
            app.Run(async (context) =>
            {
                await context.
                Response.WriteAsync("process name executing the app " + System.Diagnostics.Process.GetCurrentProcess().ProcessName);
            });
        }
    }
}
