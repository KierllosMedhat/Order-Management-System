using System.Data.Context;
using System.Data.Entities;

namespace OrderManagementSystem.API.Helper
{
    public class DataGenerator
    {
        public static void Initialize(WebApplication app)
        {
            var scope = app.Services.CreateScope();
            var db = scope.ServiceProvider.GetService<OrderManagementDbContext>();
            {
                // Look for any products
                if (db.Products.Any())
                {
                    return;   // Data was already seeded
                }

                db.Products.AddRange(
                    new Product
                    {
                        Name = "Product1",
                        Price = 12.5,
                        Stock = 30
                    },
                    new Product
                    {
                        Name = "Product2",
                        Price = 15.0,
                        Stock = 10
                    });

                db.SaveChanges();
            }
        }
    }
}
