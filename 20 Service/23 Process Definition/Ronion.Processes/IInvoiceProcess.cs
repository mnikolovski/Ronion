using Ronion.Common.Base.Repository;
using Ronion.Common.Base.Results;
using Ronion.Entities;

namespace Ronion.Processes
{
    public interface IInvoiceProcess
    {
        /// <summary>
        /// Create new order in the system
        /// </summary>
        /// <param name="requestingUser">The user that creates the order</param>
        /// <param name="invoice"></param>
        /// <returns>Id of the newly created order</returns>
        MethodResult<int> CreateInvoice(User requestingUser, Invoice invoice);
        
        /// <summary>
        /// Return a list of order's customers
        /// </summary>
        /// <param name="requestingUser"></param>
        /// <param name="customer">The actual </param>
        /// <param name="queryOptions"></param>
        /// <returns></returns>
        ListResult<Invoice> GetCustomerInvoices(User requestingUser, Customer customer, QueryOptions queryOptions);

        /// <summary>
        /// Send invoice to a customer via available channels
        /// </summary>
        /// <param name="requestingUser">The user that creates the invoice</param>
        /// <param name="invoice">The actual invoice</param>
        /// <returns></returns>
        VoidResult SendInvoiceToCustomer(User requestingUser, Invoice invoice);
    }
}
