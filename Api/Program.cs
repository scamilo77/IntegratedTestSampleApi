using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Api
{
    public class Program
    {
        public static string PathToContentRoot { get; set; }
        public static IConfiguration Configuration { get; set; }

        public static void Main(string[] args)
        {
            var pathToExe = Process.GetCurrentProcess().MainModule.FileName;
            PathToContentRoot = Path.GetDirectoryName(pathToExe);
            CreateHostBuilder(args).Run();
        }

        public static IWebHost CreateHostBuilder(string[] args)
        {
            var port = Environment.GetEnvironmentVariable("PORT") ?? "5000";

            return WebHost.CreateDefaultBuilder(args)
            .UseStartup<Startup>()
            .UseContentRoot(Directory.GetCurrentDirectory())
            .ConfigureAppConfiguration((hosting, config) =>
            {
                var environment = hosting.HostingEnvironment;

                config
                    .AddEnvironmentVariables()
                    .SetBasePath(environment.ContentRootPath)
                    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                    .AddJsonFile($"appsettings.{environment.EnvironmentName}.json", optional: true, reloadOnChange: true);
            })
            .UseUrls($"http://0.0.0.0:{port}")
            .UseKestrel()
            .ConfigureLogging(logging =>
            {
                logging.ClearProviders();
                logging.AddDebug();
                logging.AddConsole();
            })
            //.UseContentRoot(PathToContentRoot)
            .Build();
        }
    }
}
