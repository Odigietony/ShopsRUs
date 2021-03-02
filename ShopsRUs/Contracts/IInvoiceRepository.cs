using ShopsRUs.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopsRUs.Contracts
{
    public interface IInvoiceRepository
    {
        Task<Invoice> GetTotalInvoiceAmount(string billNumber, bool trackChanges);
        void GenerateInvoiceForCustomer(int userId, Invoice invoice);
    }
}
