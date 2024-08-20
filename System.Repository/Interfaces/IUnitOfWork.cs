using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Repository.Interfaces
{
    public interface IUnitOfWork
    {
        public ICustomerRepository CustomerRepository { get; set; }
        public IOrderRepository OrderRepository { get; set; }
        public IProductRepository ProductRepository { get; set; }
        public IInvoiceRepository InvoiceRepository { get; set; }
        public IUserRepository UserReposiotry { get; set; }

        public int Complete(); 
    }
}
