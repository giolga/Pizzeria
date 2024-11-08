using Microsoft.EntityFrameworkCore;
using Pizzeria.Models;

namespace Pizzeria.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<PizzaOrder> PizzaOrders { get; set; }
    }
}
