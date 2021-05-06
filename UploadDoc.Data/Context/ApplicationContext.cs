using Microsoft.EntityFrameworkCore;
using UploadDoc.Data.Extensions;
using UploadDoc.Data.Mapping;
using UploadDoc.Domain.Entities;

namespace UploadDoc.Data.Context
{
    public partial class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> option) : base(option)
        {

        }
        public virtual DbSet<Pessoa> Pessoas { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PessoaMap());

            // Toda Vez que rodar uma migration insere dados padroes no banco conforme configurado no SeedData
            modelBuilder.SeedData();

            base.OnModelCreating(modelBuilder);
        }

        //partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
