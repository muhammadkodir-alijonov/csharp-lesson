using EfCore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCore.DbContexts
{
    public class AppDbContext : DbContext
    {
        public virtual DbSet<User> Users { get; set; } = default!;
        public virtual DbSet<Car> Cars { get; set; } = default!;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost; Port=5432; Database=ef-core-db; User Id=postgres; Password=alijonovm;");
        }
    }
}
