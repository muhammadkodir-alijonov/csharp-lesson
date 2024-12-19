using CarShop.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace CarShop.Api.Common.DbContexts;
public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {

    }
    public virtual DbSet<Car> Cars { get; set; } = default!;

    public virtual DbSet<User> Users { get; set; } = default!;

    public virtual DbSet<Order> Orders { get; set; } = default!;
}
