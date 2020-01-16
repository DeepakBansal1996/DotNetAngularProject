using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace DatingApp.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            NewMethod3(args);

            static void NewMethod3(string[] args)
            {
                NewMethod2(args);
            }
        }

        private static void NewMethod2(string[] args)
        {
            NewMethod1(args);
        }

        private static void NewMethod1(string[] args)
        {
            NewMethod(args);
        }

        private static void NewMethod(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args)
        {
            IHostBuilder hostBuilder = Host.CreateDefaultBuilder(args)
                            .ConfigureWebHostDefaults(webBuilder =>
                            {
                                webBuilder.UseStartup<Startup>();
                            });
            return hostBuilder;
        }
    }
}
