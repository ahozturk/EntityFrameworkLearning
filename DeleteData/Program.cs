using Microsoft.EntityFrameworkCore;

ExampleDbContext context = new ExampleDbContext();

//Product? product1 = await context.Products.FirstOrDefaultAsync(p => p.Id == 5);
//if (product1 != null)
//    context.Products.Remove(product1);
//await context.SaveChangesAsync();

//---

//Product product2 = new()
//{
//    Id = 2,
//};
//context.Products.Remove(product2);
//await context.SaveChangesAsync();

//---

//Product product3 = new()
//{
//    Id = 1,
//};
//context.Entry(product3).State = EntityState.Deleted;
//await context.SaveChangesAsync();

//---

var productList = await context.Products.Where(p => p.Id > 3).ToListAsync();
context.Products.RemoveRange(productList);
await context.SaveChangesAsync();


public class ExampleDbContext : DbContext
{
    public DbSet<Product> Products { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=DESKTOP-L858T4B;Database=ExampleDb;User Id=hakan;Password=sifre1234;Encrypt=True;TrustServerCertificate=True;");
    }
}

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
}