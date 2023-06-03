// See https://aka.ms/new-console-template for more information
using CreatingQueries;
using Microsoft.EntityFrameworkCore;

Console.WriteLine("Hello, World!");
ExampleDbContext _context = new();

//var data = await _context.Products.SingleAsync(p => p.Name == "Test");

//var data = await _context.Products.SingleOrDefaultAsync(p => p.Id < 0);

//var data1 = await _context.Products.FirstAsync(p => p.Name == "Test");
//var data2 = await _context.Products.FirstAsync(p => p.Name == "Test");
//var data3 = await _context.Products.FirstAsync(p => p.Name == "Test");
//var data4 = await _context.Products.FirstAsync(p => p.Name == "Test");

//var data5 = await _context.Products.FindAsync(10);

var data6 = await _context.Products.OrderBy(p => p.Id).LastOrDefaultAsync(p => p.Price > 20);

Console.WriteLine();