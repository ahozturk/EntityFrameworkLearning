using CreatingQueries;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

ExampleDbContext _context = new();

//ToDictionary
var data = await _context.Products.ToDictionaryAsync(k => k.Id, v => v.Price);

var datas = await _context.Products.Select(p => new
{
    Id = p.Id
}).ToListAsync();


//var datas2 = await _context.Products.Include(p => p.)
Console.WriteLine();