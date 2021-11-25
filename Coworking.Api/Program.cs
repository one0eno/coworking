using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Coworking.Api
{
    public class Program
    {


        //esto es una prueba
        public static void Main(string[] args)
        {
            var dd = "esto es master";
            var kk = " esto es lo quee arregla la issue1";
            var kk2 = " linea de issue2";
            var kk2 = " linea de issue2 segundo commit";
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
