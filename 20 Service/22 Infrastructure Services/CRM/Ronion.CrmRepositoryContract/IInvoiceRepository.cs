using System.Collections.Generic;
using Ronion.Common.Base.Repository;
using Ronion.Entities;

namespace Ronion.CrmRepositoryContract
{
    /// <summary>
    /// Represents invoice repository
    /// </summary>
    public interface IInvoiceRepository : IBaseRepository<Invoice>
    {
        /// <summary>
        /// Return a list of customer invoices
        /// </summary>
        /// <param name="customer"></param>
        /// <param name="queryOptions"></param>
        List<Invoice> GetCustomerInvoices(Customer customer, QueryOptions queryOptions);

        /// <summary>
        /// Update an existing invoice by adding a product
        /// </summary>
        /// <param name="invoice"></param>
        /// <param name="product"></param>
        void AddInvoiceLine(Invoice invoice, Product product);

        /// <summary>
        /// Update an existing invoice by removing a product
        /// </summary>
        /// <param name="invoice"></param>
        /// <param name="product"></param>
        void RemoveInvoiceLine(Invoice invoice, Product product);
    }
}
