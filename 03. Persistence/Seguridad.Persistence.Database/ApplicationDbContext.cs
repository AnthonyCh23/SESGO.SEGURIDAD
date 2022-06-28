using Microsoft.EntityFrameworkCore;
using Seguridad.Domain;
using Seguridad.Persistence.Database.Configuration;
using System;

namespace Seguridad.Persistence.Database
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {

        }

        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Password> Password { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.HasDefaultSchema("Seguridad");
            ModelConfig(modelBuilder);
        }

        private void ModelConfig(ModelBuilder modelBuilder)
        {
            new UsuarioConfiguration(modelBuilder.Entity<Usuario>());
            new PasswordConfiguration(modelBuilder.Entity<Password>());
        }
    }
}
