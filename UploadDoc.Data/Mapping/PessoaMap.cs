using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using UploadDoc.Domain.Entities;

namespace UploadDoc.Data.Mapping
{
    public class PessoaMap : IEntityTypeConfiguration<Pessoa>
    {
        public void Configure(EntityTypeBuilder<Pessoa> builder)
        {
            builder.Property(e => e.PessoaId).HasColumnName("PessoaID");

            builder.Property(e => e.Nome)
                    .IsRequired()
                    .IsUnicode(false);
        }
    }
}
