using Microsoft.EntityFrameworkCore;
using PizzaOrder.Models;

namespace PizzaOrder.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<PizzaOrderModel> PizzaOrders { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)  : base(options)
        {

        }
    }
}
