using Ronion.Common.Base.Repository;
using Ronion.Common.Base.Results;
using Ronion.CrmRepositoryContract;
using Ronion.CrmRepositoryContract.Extensibility.Imports;
using Ronion.DomainServices.Extensions;
using Ronion.DomainServicesContracts;
using Ronion.DomainServicesContracts.BaseContracts;
using Ronion.DomainServicesContracts.Extensibility.Exports;
using Ronion.DomainServicesContracts.Extensibility.Imports;
using Ronion.Entities;

namespace Ronion.DomainServices.Security
{
    /// <summary>
    /// Invoice security service check the security of the calls and propage to the invoice business service
    /// </summary>
    [SecurityExport(typeof(IInvoiceService))]
    internal class InvoiceSecurityService : IInvoiceService, ISecurityService
    {
        [DataAccessImport]
        IUserRepository UserRepository { get; set; }

        [BusinessLogicImport]
        IInvoiceService BusinessService { get; set; }

        /// <summary>
        /// Create new order in the system
        /// </summary>
        /// <param name="requestingUser">The user that creates the order</param>
        /// <param name="invoice"></param>
        /// <returns>Id of the newly created order</returns>
        public MethodResult<int> CreateInvoice(User requestingUser, Invoice invoice)
        {
            var isExistingUser = UserRepository.IsRegisteredUser(requestingUser);
            ValidationExtensions.Requires(isExistingUser, "Invoice can be created only for existing users");
            // check security...
            return BusinessService.CreateInvoice(requestingUser, invoice);
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
            var isExistingUser = UserRepository.IsRegisteredUser(requestingUser);
            ValidationExtensions.Requires(isExistingUser, "User must exist in order to GetCustomerInvoices");
            return BusinessService.GetCustomerInvoices(requestingUser, customer, queryOptions);
        }

        /// <summary>
        /// Send invoice to a customer via available channels
        /// </summary>
        /// <param name="requestingUser">The user that creates the invoice</param>
        /// <param name="invoice">The actual invoice</param>
        /// <returns></returns>
        public VoidResult SendInvoiceToCustomer(User requestingUser, Invoice invoice)
        {
            var isExistingUser = UserRepository.IsRegisteredUser(requestingUser);
            ValidationExtensions.Requires(isExistingUser, "Invoice can be sent only by existing users");
            return BusinessService.SendInvoiceToCustomer(requestingUser, invoice);
        }
    }
}