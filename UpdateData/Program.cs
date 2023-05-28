using Microsoft.EntityFrameworkCore;
using UpdateData.Context;
using UpdateData.Entities;




namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            AppDbContext _appDbContext = new AppDbContext();

            var customer = await _appDbContext.Customers.FirstOrDefaultAsync(urun => urun.Id == 3) ?? new Customer();
            Console.WriteLine(_appDbContext.Entry(customer).State);

            customer.Name = "Updatedd";
            Console.WriteLine(_appDbContext.Entry(customer).State);

            _appDbContext.SaveChanges();
            Console.WriteLine(_appDbContext.Entry(customer).State);
        }
    }
}