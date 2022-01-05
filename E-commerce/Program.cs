using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_commerce
{
    public class Program
    {

        //starting point of the application
        //as main function is called first it starts as console application in server
        public static void Main(string[] args)
        {
            //object of Ihostbuilder//
            //this method is called and then application become a asp application   //
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    //use startup file as first showed in solution explorer//
                    webBuilder.UseStartup<Startup>();
                });
    }
}
