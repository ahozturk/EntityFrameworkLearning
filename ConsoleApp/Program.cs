using CodeFirst.Context;
using Microsoft.EntityFrameworkCore;

ECommerceDbContext dbContext = new();
dbContext.Database.MigrateAsync();
