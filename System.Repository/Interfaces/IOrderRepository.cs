using System;
using System.Collections.Generic;
using System.Data.Entities;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Repository.Interfaces
{
    public interface IOrderRepository
    {
        void CreateOrder(Order order);
        Task<Order> GetOrderAsync(int orderId);
        Task<IReadOnlyList<Order>> GetAllOrders();
        void UpdateOrderStatus(int orderId, Status status);
    }
}
