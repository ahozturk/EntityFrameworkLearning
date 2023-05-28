using PersistingTheData.Context;
using PersistingTheData.Entities;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
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

        }
    }
}