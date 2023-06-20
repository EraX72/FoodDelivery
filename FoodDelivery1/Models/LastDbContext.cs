using Microsoft.EntityFrameworkCore;
using Last.Models;



namespace FoodDelivery1.Models
{
    public class LastDbContext : DbContext
    {
        public DbSet<Order> Orders { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<DeliveryPerson> DeliveryPersons { get; set; }
        public DbSet<Customer> Customers { get; set; }

        public LastDbContext(DbContextOptions<LastDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }
    }
}
