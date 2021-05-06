﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UploadDoc.Data.Context;

namespace UploadDoc.Data.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20210506163350_Inserting Default Person")]
    partial class InsertingDefaultPerson
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
                    b.Property<int>("PessoaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("PessoaID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(max)")
                        .IsUnicode(false);

                    b.Property<int>("Prontuario")
                        .HasColumnType("int");

                    b.HasKey("PessoaId");

                    b.ToTable("Pessoas");

                    b.HasData(
                        new
                        {
                            PessoaId = 1,
                            Nome = "Administrador Teste",
                            Prontuario = 123456
                        });
                });
#pragma warning restore 612, 618
        }
    }
}