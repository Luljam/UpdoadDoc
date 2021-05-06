using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using UploadDoc.Domain.Entities;

namespace UploadDoc.Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static ModelBuilder SeedData(this ModelBuilder builder)
        {
            builder.Entity<Pessoa>()
                .HasData(
                    new Pessoa { PessoaId =1, Prontuario = 123456, Nome = "Administrador Teste"  }
                );
            return builder;
        }
    }
}
