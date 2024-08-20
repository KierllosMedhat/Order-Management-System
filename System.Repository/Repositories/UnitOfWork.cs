using System;
using System.Collections.Generic;
using System.Data.Context;
using System.Linq;
using System.Repository.Interfaces;
using System.Text;
using System.Threading.Tasks;

namespace System.Repository.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly OrderManagementDbContext context;

        public ICustomerRepository CustomerRepository { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IOrderRepository OrderRepository { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IProductRepository ProductRepository { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IInvoiceRepository InvoiceRepository { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IUserRepository UserReposiotry { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public UnitOfWork(OrderManagementDbContext context)
        {
            this.context = context;
            CustomerRepository = new CustomerRepository(context);
            OrderRepository = new OrderRepository(context);
            ProductRepository = new ProductRepository(context);
            InvoiceRepository = new InvoiceRepository(context);
            UserReposiotry = new UserRepository(context);
        }

        public int Complete()
            => context.SaveChanges();
    }
}
