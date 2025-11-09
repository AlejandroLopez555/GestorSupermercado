using System.Data.Entity;

namespace SistemaControlProductos.Models
{
    public class SupermercadoContext : DbContext
    {
        public SupermercadoContext() : base("name=SupermercadoContext")
        {
        }

        public DbSet<Producto> Productos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Proveedor> Proveedores { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Forzar nombres correctos en español
            modelBuilder.Entity<Producto>().ToTable("Productos");
            modelBuilder.Entity<Categoria>().ToTable("Categorias");
            modelBuilder.Entity<Proveedor>().ToTable("Proveedores");

            base.OnModelCreating(modelBuilder);
        }
    }
}