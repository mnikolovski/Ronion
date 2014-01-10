using System;
using Ronion.Common.Base.Repository;
using Ronion.Common.Base.Results;
using Ronion.DomainServices.Extensions;
using Ronion.DomainServicesContracts;
using Ronion.DomainServicesContracts.BaseContracts;
using Ronion.DomainServicesContracts.Extensibility.Exports;
using Ronion.DomainServicesContracts.Extensibility.Imports;
using Ronion.Entities;

namespace Ronion.DomainServices.Validation
{
    /// <summary>
    /// Invoice validation service validate the calls data and propage to the invoice security service
    /// </summary>
    [ValidationExport(typeof(IInvoiceService))]
    internal class InvoiceValidationService : IInvoiceService, IValidationService
    {
        [SecurityImport]
        IInvoiceService SecurityService { get; set; }

        /// <summary>
        /// Create new order in the system
        /// </summary>
        /// <param name="requestingUser">The user that creates the order</param>
        /// <param name="invoice"></param>
        /// <returns>Id of the newly created order</returns>
        public MethodResult<int> CreateInvoice(User requestingUser, Invoice invoice)
        {
            // do validation of the call
            ValidationExtensions.Requires(requestingUser != null, "requestingUser cannot be null.");
            ValidationExtensions.Requires(invoice != null, "invoice cannot be null.");
            return SecurityService.CreateInvoice(requestingUser, invoice);
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
            // do validation of the call
            ValidationExtensions.Requires(requestingUser != null, "requestingUser cannot be null.");
            ValidationExtensions.Requires(customer != null, "customer cannot be null.");
            return SecurityService.GetCustomerInvoices(requestingUser, customer, queryOptions);
        }

        /// <summary>
        /// Send invoice to a customer via available channels
        /// </summary>
        /// <param name="requestingUser">The user that creates the invoice</param>
        /// <param name="invoice">The actual invoice</param>
        /// <returns></returns>
        public VoidResult SendInvoiceToCustomer(User requestingUser, Invoice invoice)
        {
            // do validation of the call
            ValidationExtensions.Requires(requestingUser != null, "requestingUser cannot be null.");
            ValidationExtensions.Requires(requestingUser.Email != null, "requestingUser.Email cannot be null.");
            ValidationExtensions.Requires(invoice != null, "invoice cannot be null.");
            return SecurityService.SendInvoiceToCustomer(requestingUser, invoice);
        }
    }
}