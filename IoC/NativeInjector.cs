using Microsoft.Extensions.DependencyInjection;
using System;
using UploadDoc.Application.Interfaces;
using UploadDoc.Application.Services;

namespace IoC
{
    public static class NativeInjector
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddScoped<IPessoaService, PessoaService>();
        }
    }
}
