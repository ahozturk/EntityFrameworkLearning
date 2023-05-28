using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UpdateData.Entities;

namespace UpdateData.Context
{
    public class AppDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-L858T4B;Database=UpdateDb;User Id=hakan;Password=sifre1234;Encrypt=True;TrustServerCertificate=True;");
        }
    }
}
