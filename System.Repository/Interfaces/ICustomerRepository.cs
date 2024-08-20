

using System.Data.Entities;

namespace System.Repository.Interfaces
{
    public interface ICustomerRepository
    {
        void CreateCustomer(Customer customer);
        Task<IEnumerable<Order>> GetOrdersAsync(int customerId);
    }
}
