using CreatingQueries;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

ExampleDbContext _context = new();

#region Select - Deffered Execution
int minId = 10;
string nameMustContains = "hakan";
// var products = await _context.Products.ToListAsync();

var products2 = from selectedProducts in _context.Products
                where selectedProducts.Id > minId && selectedProducts.Name.Contains(nameMustContains)
                select selectedProducts;


minId = 20;
nameMustContains = "yeliz";
foreach (Product product in products2)
{
    Console.WriteLine($"Product Name: {product.Name}");
}
#endregion

Console.WriteLine();