using CreatingQueries;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

ExampleDbContext _context = new();

//int count = _context.Products.ToList().Count; //Performance -
int count = await _context.Products.CountAsync(); //Performance +

int countOfExpensiveProducts = await _context.Products.CountAsync(x => x.Price > 1000);
//For return long type use -> LongCountAsync()

bool isAnyNameContainsA = await _context.Products.AnyAsync(p => p.Name.Contains("e"));

float maxPrice = await _context.Products.MaxAsync(p => p.Price);

var comp = new ProductEqualityComparer();

var datas = _context.Products.AsEnumerable().Distinct(new ProductEqualityComparer()).ToList() ;

//Distinct -> clean from repeating datas

Console.WriteLine();
Console.WriteLine("Hello, World!");


class ProductEqualityComparer : IEqualityComparer<Product>
{
    public bool Equals(Product? x, Product? y)
    {
        if (x == null && y == null)
            return true;
        else if (x == null || y == null)
            return false;
        else if (x.Name == "Test2" || y.Name == "Test2")
            return true;
        else if (x.Name == y.Name)
            return true;
        return false;
    }

    public int GetHashCode([DisallowNull] Product obj)
    {
        return obj.Name.GetHashCode();
    }
}