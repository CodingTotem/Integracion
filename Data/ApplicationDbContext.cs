using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Models.Entidades;
using Models.Entities;

namespace Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<PrecioOferta> PrecioOfertas { get; set; }
    }
}