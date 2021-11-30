﻿using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Coworking.Api.Config
{
    public static class SwaggerConfig
    {

        /// <summary>
        /// Configuracion de swagger
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddRegistration(this IServiceCollection services)
        {
            Microsoft.OpenApi.Models.OpenApiInfo info = new Microsoft.OpenApi.Models.OpenApiInfo();
            info.Title = "Coworking API";
            info.Version = "V1";

            string basePath = System.AppDomain.CurrentDomain.BaseDirectory;
            string xmlPath = Path.Combine(basePath, "Coworking.Api.xml");


            services.AddSwaggerGen(c =>
                {
                    c.SwaggerDoc("V1", info);
                    c.IncludeXmlComments(xmlPath);

                }

            ) ;

            return services;
        }

        /// <summary>
        /// Activación de applicationBuilder
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IApplicationBuilder AddRegistration(this IApplicationBuilder app)
        {
            app.UseSwagger();

            //Indicamos donde esta el JSON del endpoint
            app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Coworking API V1"));

            return app;

        }


    }
}
