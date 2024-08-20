using Microsoft.EntityFrameworkCore;
using System.Data.Context;
using System.Data.Entities;
using System.Repository.Interfaces;

namespace System.Repository.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly OrderManagementDbContext context;

        public ProductRepository(OrderManagementDbContext context) 
        {
            this.context = context;
        }

        public async void AddProduct(Product product)
            => await context.Products.AddAsync(product);

        public async Task<IReadOnlyList<Product>> GetAllProductsAsync()
            => await context.Products.ToListAsync();

        public async Task<Product> GetProductAsync(int id)
            => await context.Products.FindAsync(id);

        public void UpdateProduct(Product product)
            => context.Products.Update(product);
    }
}
