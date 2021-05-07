using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using System;
using System.IO;

namespace UploadDoc.Swagger
{
    public static class SwaggerSetup
    {
        // configurações do Swagger
        public static IServiceCollection AddSwaggerConfiguration(this IServiceCollection service)
        {
            return service.AddSwaggerGen(opt =>
            {
                opt.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "Upload .Net Core",
                    Version = "v1",
                    Description = "Desenvolvimento de Api com A.Net Core e Angular.",
                    Contact = new OpenApiContact
                    {
                        Name = "Luciano Brito",
                        Email = "lucianofdebrito@gmail.com"
                    }
                });
                var xmlPath = Path.Combine("wwwroot", "api-doc.xml");
                opt.IncludeXmlComments(xmlPath);
            });
        }

        // Configurações da rota. Será lido me classe StartUp Configure
        public static IApplicationBuilder UseSwaggerConfiguration(this IApplicationBuilder app)
        {
            return app.UseSwagger().UseSwaggerUI(c =>
            {
                c.RoutePrefix = "documentation";
                c.SwaggerEndpoint("../swagger/v1/swagger.json", "API v1");
            });
        }
    }
}
