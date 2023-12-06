using GTY.Models;
using Microsoft.EntityFrameworkCore;

namespace GTY.Data
{
    public class OxeDbContext : DbContext
    {
        public OxeDbContext(DbContextOptions<OxeDbContext> options) : base(options)
        {
        }
        public DbSet<OxePessoasModel> Pessoas { get; set; }
        public DbSet<OxeCidadesModel> Cidades { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configuração da chave primária para OxeCidadesModel
            modelBuilder.Entity<OxeCidadesModel>().HasKey(c => c.CidadeId);

            // Configuração do relacionamento
            modelBuilder.Entity<OxePessoasModel>()
                .HasOne(p => p.Cidade)
                .WithMany(c => c.Pessoas)
                .HasForeignKey(p => p.CidadeId)
                .OnDelete(DeleteBehavior.Restrict);

            // Outras configurações e métodos do DbContext, se necessário
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    // Configuração do relacionamento
        //    modelBuilder.Entity<OxePessoasModel>()
        //        .HasOne(p => p.Cidade)
        //        .WithMany(c => c.Pessoas)
        //        .HasForeignKey(p => p.CidadeId)
        //        .OnDelete(DeleteBehavior.Restrict);
        //}

        // Outras configurações e métodos do DbContext, se necessário
    }
}
