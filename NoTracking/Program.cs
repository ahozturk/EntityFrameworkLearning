// See https://aka.ms/new-console-template for more information


using GroupBy;
using Microsoft.EntityFrameworkCore;

YourDatabaseNameContext _context = new();
var datas = _context.Products.AsNoTracking().ToList();

foreach (var data in datas)
{
    Console.WriteLine(data.ProductName);
}
Console.WriteLine();


//AsNoTrackingWithIdentityResolution()
//If there are some entities in relationship, to write optimized code we can use this method. AsNoTrackingWithIdentityResolution means there is no tracing mechanism for entity changes but also there is tracing mechanism for detect relational datas.

//UseQueryTrackingBehavior() on OnConfiguring
//There are 3 parameters to give this function
//TrackAll -> Default Version of Tracking (TrackAll and make IdentityResolution)
//NoTrackingWithIdentityMechanism -> there is no tracing mechanism for entity changes but also there is tracing mechanism for detect relational datas.
//NoTracking -> No Tracking!

//AsTracking()
//If tracking mechanism disabled, to enable we use this method