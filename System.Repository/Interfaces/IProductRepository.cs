using System;
using System.Collections.Generic;
using System.Data.Entities;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Repository.Interfaces
{
    public interface IProductRepository
    {
        Task<IReadOnlyList<Product>> GetAllProductsAsync();
        Task<Product> GetProductAsync(int id);
        void AddProduct(Product product);
        void UpdateProduct(Product product);
    }
}
