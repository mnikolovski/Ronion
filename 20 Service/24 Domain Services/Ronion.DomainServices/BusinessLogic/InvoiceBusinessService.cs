using System.Net.Mail;
using Ronion.Common.Base.Repository;
using Ronion.Common.Base.Results;
using Ronion.CrmRepositoryContract;
using Ronion.CrmRepositoryContract.Extensibility.Imports;
using Ronion.DomainServicesContracts;
using Ronion.DomainServicesContracts.BaseContracts;
using Ronion.DomainServicesContracts.Extensibility.Exports;
using Ronion.Entities;
using Ronion.MailSenderContract;
using Ronion.MailSenderContract.Extensibility.Imports;

namespace Ronion.DomainServices.BusinessLogic
{
    /// <summary>
    /// Invoice Business handling the business logic
    /// </summary>
    [BusinessLogicExport(typeof(IInvoiceService))]
    internal class InvoiceBusinessService : IInvoiceService, IBusinessService
    {
        [DataAccessImport]
        IInvoiceRepository InvoiceRepository { get; set; }

        [MailSenderImport]
        IMailSender MailSender { get; set; }

        /// <summary>
        /// Create new order in the system
        /// </summary>
        /// <param name="requestingUser">The user that creates the order</param>
        /// <param name="invoice"></param>
        /// <returns>Id of the newly created order</returns>
        public MethodResult<int> CreateInvoice(User requestingUser, Invoice invoice)
        {
            var invoiceId = InvoiceRepository.Create(invoice);
            // send email to the customer
            MailSender.SendMail(new MailMessage(@"john@doe.com", invoice.Customer.Email));
            return new MethodResult<int>(invoiceId);
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
            var invoices = InvoiceRepository.GetCustomerInvoices(customer, queryOptions);
            return new ListResult<Invoice>(invoices);
        }

        /// <summary>
        /// Send invoice to a customer via available channels
        /// </summary>
        /// <param name="requestingUser">The user that creates the invoice</param>
        /// <param name="invoice">The actual invoice</param>
        /// <returns></returns>
        public VoidResult SendInvoiceToCustomer(User requestingUser, Invoice invoice)
        {
            MailSender.SendMail(new MailMessage(@"john@doe.com", requestingUser.Email));
            return new VoidResult();
        }
    }
}