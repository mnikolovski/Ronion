using Ronin.LoggerContract;
using Ronin.LoggerContract.Extensibility.Imports;
using Ronion.Common.Base.Repository;
using Ronion.Common.Base.Results;
using Ronion.DomainServices.Extensions;
using Ronion.DomainServicesContracts;
using Ronion.DomainServicesContracts.BaseContracts;
using Ronion.DomainServicesContracts.Extensibility.Exports;
using Ronion.DomainServicesContracts.Extensibility.Imports;
using Ronion.Entities;

namespace Ronion.DomainServices.ExceptionHandling
{
    /// <summary>
    /// Invoice Exception handling service wraps the calls and propage to the invoice validation service
    /// </summary>
    [EntryPointExport(typeof(IInvoiceService))]
    internal class InvoiceExceptionHandlingService : IInvoiceService, IEntryPointService, IExceptionHandlingService
    {
        [LoggerImport]
        public ILogger Logger { get; set; }

        [ValidationImport]
        IInvoiceService ValidationService { get; set; }

        /// <summary>
        /// Create new order in the system
        /// </summary>
        /// <param name="requestingUser">The user that creates the order</param>
        /// <param name="invoice"></param>
        /// <returns>Id of the newly created order</returns>
        public MethodResult<int> CreateInvoice(User requestingUser, Invoice invoice)
        {
            return this.WrapRequestResponseCall(() => ValidationService.CreateInvoice(requestingUser, invoice));
        }

        /// <summary>
        /// Return a list of order's customers
        /// </summary>
        /// <param name="requestingUser"></param>
        /// <param name="customer">The actual </param>
        /// <param name="queryOptions"></param>
        /// <returns></returns>
        public ListResult<Invoice> GetCustomerInvoices(User requestingUser, Customer customer, QueryOptions queryOptions)
        {
            return this.WrapRequestResponseCall(() => ValidationService.GetCustomerInvoices(requestingUser, customer, queryOptions));
        }

        /// <summary>
        /// Send invoice to a customer via available channels
        /// </summary>
        /// <param name="requestingUser">The user that creates the invoice</param>
        /// <param name="invoice">The actual invoice</param>
        /// <returns></returns>
        public VoidResult SendInvoiceToCustomer(User requestingUser, Invoice invoice)
        {
            return this.WrapRequestResponseCall(() => ValidationService.SendInvoiceToCustomer(requestingUser, invoice));
        }
    }
}