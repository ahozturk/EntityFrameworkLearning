using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata.Ecma335;

Console.WriteLine();
public class ETicaretDbContext : DbContext
{
    public DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=DESKTOP-L858T4B;Database=ECommerceDb;User Id=hakan;Password=sifre1234;Encrypt=True;TrustServerCertificate=True;");
    }
}

public class Product
{
    public int Id { get; set; }

}