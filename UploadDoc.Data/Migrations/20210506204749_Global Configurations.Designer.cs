// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UploadDoc.Data.Context;

namespace UploadDoc.Data.Migrations
{
    [DbContext(typeof(DbContextOptionsBuilder))]
    [Migration("20210506204749_Global Configurations")]
    partial class GlobalConfigurations
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("UploadDoc.Domain.Entities.Pessoa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("PessoaID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateCreaded")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2021, 5, 6, 17, 47, 49, 238, DateTimeKind.Local).AddTicks(8674));

                    b.Property<DateTime?>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(max)")
                        .IsUnicode(false);

                    b.Property<int>("Prontuario")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Pessoas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateCreaded = new DateTime(2021, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = true,
                            Nome = "Administrador Teste",
                            Prontuario = 123456
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
