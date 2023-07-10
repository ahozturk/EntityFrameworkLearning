using Microsoft.EntityFrameworkCore;
using RelationalTables.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelationalTables.Context
{
    internal class CompanyDbContext : DbContext
    {
        DbSet<Employee> Employees { get; set; }
        DbSet<Address> Address { get; set; }
        DbSet<Department> Departments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-L858T4B;Database=CompanyDb;User Id=hakan;Password=sifresql;Encrypt=True;TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Fluent API
            //modelBuilder.Entity<Employee>()
            //    .HasKey(employee => employee.Id);

            //modelBuilder.Entity<Employee>()
            //    .HasOne(employee => employee.Address)
            //    .WithOne(address => address.Employee)
            //    .HasForeignKey<Address>(address => address.Id);
        }
    }
}
