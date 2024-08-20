using System;
using System.Collections.Generic;
using System.Data.Entities;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Repository.Interfaces
{
    public interface IInvoiceRepository
    {
        Task<Invoice> GetInvoiceById(int id);
        Task<IReadOnlyList<Invoice>> GetAllInvoices();
    }
}
