using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiTenStore.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Product> Products {get; set;}
        public DbSet<Tercero> Terceros {get; set;}
        public DbSet<CabezaFactura> CabezaFacturas {get; set;}
        public DbSet<CuerpoFactura> CuerpoFacturas {get; set;}

    }
}
