// See https://aka.ms/new-console-template for more information
using PersistingTheData.Context;
using PersistingTheData.Entities;

Console.WriteLine("Hello, World!");

ExampleDbContext _context = new();
var product = new Product()
{
    Name = "Test",
};

Console.WriteLine(_context.Entry(product).State);
await _context.AddAsync(product);
Console.WriteLine(_context.Entry(product).State);
await _context.SaveChangesAsync();
Console.WriteLine(_context.Entry(product).State);
_context.Remove(product);
Console.WriteLine(_context.Entry(product).State);