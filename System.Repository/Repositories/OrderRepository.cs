using Microsoft.EntityFrameworkCore;
using System.Data.Context;
using System.Data.Entities;
using System.Repository.Interfaces;

namespace System.Repository.Repositories
{
    public class OrderRepository : IOrderRepository
    {

        private readonly OrderManagementDbContext context;

        public OrderRepository(OrderManagementDbContext context)
        {
            this.context = context;
        }

        public async void CreateOrder(Order order)
            => await context.Orders.AddAsync(order);

        public async Task<Order> GetOrderAsync(int orderId)
            => await context.Orders.FindAsync(orderId);

        public async Task<IReadOnlyList<Order>> GetAllOrders()
            => await context.Orders.ToListAsync();

        public void UpdateOrderStatus(int orderId, Status status)
        {
            var order = context.Orders.Find(orderId);
            if (order != null) 
            {
                order.Status = status;
                context.Orders.Update(order);
            }
        }
    }
}
