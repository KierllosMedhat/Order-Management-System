using Microsoft.EntityFrameworkCore;
using System.Data.Context;
using System.Data.Entities;
using System.Repository.Interfaces;

namespace System.Repository.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly OrderManagementDbContext context;

        public CustomerRepository(OrderManagementDbContext context) 
        {
            this.context = context;
        }

        public async void CreateCustomer(Customer customer)
            => await context.Customers.AddAsync(customer);

        public async Task<IEnumerable<Order>> GetOrdersAsync(int customerId)
            => await context.Orders.Where(o => o.CustomerId == customerId).ToListAsync();

    }
}
