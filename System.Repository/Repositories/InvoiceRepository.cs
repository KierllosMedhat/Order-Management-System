using Microsoft.EntityFrameworkCore;
using System.Data.Context;
using System.Data.Entities;
using System.Repository.Interfaces;

namespace System.Repository.Repositories
{
    public class InvoiceRepository : IInvoiceRepository
    {
        private readonly OrderManagementDbContext context;

        public InvoiceRepository(OrderManagementDbContext context) 
        {
            this.context = context;
        }

        public async Task<IReadOnlyList<Invoice>> GetAllInvoices()
            => await context.Invoices.ToListAsync();

        public async Task<Invoice> GetInvoiceById(int id)
            => await context.Invoices.FindAsync(id);
    }
}
