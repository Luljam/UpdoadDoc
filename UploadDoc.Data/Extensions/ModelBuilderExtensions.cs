using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata;
using System.Text;
using UploadDoc.Domain.Entities;
using UploadDoc.Domain.Models;

namespace UploadDoc.Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static ModelBuilder ApplyGlobalConfigurations(this ModelBuilder builder)
        {
            
            foreach (var entityType in builder.Model.GetEntityTypes())
            {
                //Para cada entidade que existe irá rodar este, para validar os campos
                foreach (var property in entityType.GetProperties())
                {
                    switch (property.Name)
                    {
                        case nameof(Entity.Id):
                            property.IsKey(); // Identifica que é Primary Key
                            break;
                        case nameof(Entity.DateUpdated):
                            property.IsNullable = true; // Aceita o valor nulo
                            break;
                        case nameof(Entity.DateCreaded):
                            property.IsNullable = false; // não aceita valou nulo
                            property.SetDefaultValue(DateTime.Now); // Seta data e hora do momento como default
                            break;
                        case nameof(Entity.IsActive):
                            property.IsNullable = false; // Não aceita valor null
                            property.SetDefaultValue(true); // Seta valor padrão com ativo
                            break;
                        default:
                            break;
                    }
                }
            }
            return builder;
        }

        public static ModelBuilder SeedData(this ModelBuilder builder)
        {
            builder.Entity<Pessoa>()
                .HasData(
                    new Pessoa { Id =1, Prontuario = 123456, Nome = "Administrador Teste" , DateCreaded = new DateTime(2021,05,05), IsActive = true }
                );
            return builder;
        }
    }
}
