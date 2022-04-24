using EfCoreCurso.Domain;
using Microsoft.EntityFrameworkCore;

namespace EfCoreCurso.Data
{
    public class ApplicationContext : DbContext
    {

        public DbSet<Pedido> Pedidos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("CursoContext");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationContext).Assembly);
        }
    }
}
