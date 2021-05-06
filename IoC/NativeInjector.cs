using Microsoft.Extensions.DependencyInjection;
using System;
using UploadDoc.Application.Interfaces;
using UploadDoc.Application.Services;
using UploadDoc.Data.Repositories;
using UploadDoc.Domain.Interfaces;

namespace IoC
{
    public static class NativeInjector
    {
        public static void RegisterServices(IServiceCollection services)
        {
            #region Services

            services.AddScoped<IPessoaService, PessoaService>();

            #endregion

            #region Repositories

            services.AddScoped<IPessoaRepository, PessoaRepository>();

            #endregion
        }
    }
}
