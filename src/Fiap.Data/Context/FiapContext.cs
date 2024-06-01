using Fiap.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Fiap.Data.Context
{
    public class FiapContext : DbContext
    {
        public FiapContext(DbContextOptions<FiapContext> options) : base(options)
        {
        }

        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Cadastro> Cadastro { get; set; }
        public DbSet<Endereco> Endereco { get; set; }
        public DbSet<Produto> Produto { get; set; }
        public DbSet<Tbl_Estabelecimento> Tbl_Estabelecimento { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasSequence<int>("seq_usuario")
                .StartsAt(1)
                .IncrementsBy(1);
            modelBuilder.Entity<Usuario>()
                .HasKey(u => u.Id_Usuario);
            modelBuilder.Entity<Usuario>()
                .Property(u => u.Id_Usuario)
                .HasDefaultValueSql("seq_usuario.NEXTVAL");

            modelBuilder.Entity<Tbl_Estabelecimento>()
                .HasKey(e => e.ID_ESTABELECIMENTO); // Define a chave primária
            modelBuilder.Entity<Cadastro>()
                .HasKey(e => e.Id_Cadastro); // Define a chave primária

            modelBuilder.Entity<Endereco>()
                .HasKey(e => e.Id_Endereco); // Define a chave primária

            modelBuilder.Entity<Endereco>()
                .HasOne(e => e.Usuario)
                .WithMany()
                .HasForeignKey(e => e.Id_Usuario); // Define a chave estrangeira

            modelBuilder.Entity<Produto>()
                .HasKey(e => e.Id_Produto); // Define a chave primária

            // Configurações adicionais do modelo, se necessário
        }
    }
}
