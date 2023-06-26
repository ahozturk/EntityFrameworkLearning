// See https://aka.ms/new-console-template for more information
using GroupBy;
using Microsoft.EntityFrameworkCore;

Console.WriteLine("Hello, World!");
YourDatabaseNameContext _context = new();

var datas = _context.Products.GroupBy(column => column.Price).Select(group => new
{
    Count = group.Count(),
    Price = group.Key
}).ToList();

var manipulatedDatas = _context.Products.ToList();

manipulatedDatas.ForEach(product =>
{
    if(product.Price > 10)
    {
        product.Price += 1000;
    }
});

Console.WriteLine();
