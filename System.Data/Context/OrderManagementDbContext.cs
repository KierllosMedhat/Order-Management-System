using Microsoft.EntityFrameworkCore;
using System.Data.Entities;

namespace System.Data.Context
{
    public class OrderManagementDbContext : DbContext
    {

        public OrderManagementDbContext(DbContextOptions<OrderManagementDbContext> options) : base(options)
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("OrderManagementDb");
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
