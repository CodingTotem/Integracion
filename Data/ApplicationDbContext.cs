using Microsoft.EntityFrameworkCore;
using Models.Entities;

namespace Data
{

    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }


        public DbSet<Categoria> Categorias { get; set; }

        public DbSet<Marca> Marca { get; set; }

        public DbSet<Producto> Productos { get; set; }


    }

}