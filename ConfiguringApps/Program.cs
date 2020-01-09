using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System.Reflection;
using System.IO;

namespace ConfiguringApps
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //BuildWebHost(args).Run;
            CreateHostBuilder(args).Start();
        }

        public static IHost CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>().UseContentRoot(Directory.GetCurrentDirectory()).UseIISIntegration();
                }).Build();
        };
}
