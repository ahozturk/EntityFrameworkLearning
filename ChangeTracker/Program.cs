// See https://aka.ms/new-console-template for more information
using GroupBy;
using Microsoft.EntityFrameworkCore;

Console.WriteLine("Hello, World!");
YourDatabaseNameContext _context = new();

var product = _context.Products.FirstOrDefault(product => product.Price > 15);
if (product != null)
{
    product.Price = 14;
    var oldPrice = _context.Entry(product).OriginalValues.GetValue<decimal?>(nameof(Product.Price));
}

//_context.ChangeTracker.DetectChanges();
//_context.ChangeTracker.AutoDetectChangesEnabled = false;
_context.SaveChanges();

var product2 = await _context.Products.FirstOrDefaultAsync(product => product.Id == 10);
if (product2 != null)
    _context.Products.Remove(product2);
_context.ChangeTracker.Entries().ToList().ForEach(entry =>
{
    if (entry.State == EntityState.Deleted)
    {
        Console.WriteLine(((Product)entry.Entity).ProductName + " Deleted");
    }
});

if (_context.ChangeTracker.HasChanges())
{

    try
    {
        await _context.SaveChangesAsync(false);
        _context.ChangeTracker.AcceptAllChanges();
    }
    catch
    {
        Console.WriteLine("Some Problem Occurred When Saving! Please Check and Save Again.");
    }
}


Console.WriteLine();