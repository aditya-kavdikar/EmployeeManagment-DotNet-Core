using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace EmployeeManagement
{
    //usually console application has program class and Main() method 
    //ASP .Net core app initially starts as console app and main() enrty point for
    public class Program
    {
        public static void Main(string[] args)
        {
            //this method returns webHostBuilder that makes ASP.NET core app as web app
            //Build() method host this app and Run() method starts app to listen to incoming http request
            CreateWebHostBuilder(args).Build().Run();
        }

        //CreateDefaultBuilder(args) static method that create web host with preconfigure defaults
        //some of the tasks that CreateDefaultBuilder(args) performs
        //1)setting up the web server
        //2)Loading the host and application configuration from various configuration sources and
        //3)configuring logging



        //UseStartup(extension method) is configuring startup class
        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
