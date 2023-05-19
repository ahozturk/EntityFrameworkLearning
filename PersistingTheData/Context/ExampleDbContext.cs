using Microsoft.EntityFrameworkCore;
using PersistingTheData.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersistingTheData.Context
{
    public class ExampleDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-L858T4B;Database=ExampleDb;User Id=hakan;Password=sifre1234;Encrypt=True;TrustServerCertificate=True;");
        }
    }
}
