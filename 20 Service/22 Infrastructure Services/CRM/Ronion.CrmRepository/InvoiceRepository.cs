using System.Collections.Generic;
using Ronion.Common.Base.Repository;
using Ronion.CrmRepositoryContract;
using Ronion.CrmRepositoryContract.Extensibility.Exports;
using Ronion.Entities;

namespace Ronion.CrmRepository
{
    /// <summary>
    /// Invoice repo to our database
    /// </summary>
    [DataAccessExport(typeof(IInvoiceRepository))]
    internal class InvoiceRepository : BaseRepository<Invoice>, IInvoiceRepository
    {
        /// <summary>
        /// Return a list of customer invoices
        /// </summary>
        /// <param name="customer"></param>
        /// <param name="queryOptions"></param>
        public List<Invoice> GetCustomerInvoices(Customer customer, QueryOptions queryOptions)
        {
            return new List<Invoice>();
        }

        /// <summary>
        /// Update an existing invoice by adding a product
        /// </summary>
        /// <param name="invoice"></param>
        /// <param name="product"></param>
        public void AddInvoiceLine(Invoice invoice, Product product)
        {
            
        }

        /// <summary>
        /// Update an existing invoice by removing a product
        /// </summary>
        /// <param name="invoice"></param>
        /// <param name="product"></param>
        public void RemoveInvoiceLine(Invoice invoice, Product product)
        {
            
        }
    }
}
