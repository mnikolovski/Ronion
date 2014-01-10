using System.Net.Mail;
using Ronion.BillingContracts;
using Ronion.BillingContracts.Extensibility.Imports;
using Ronion.Common.Base.Repository;
using Ronion.Common.Base.Results;
using Ronion.CrmRepositoryContract;
using Ronion.CrmRepositoryContract.Extensibility.Imports;
using Ronion.DomainServicesContracts;
using Ronion.DomainServicesContracts.BaseContracts;
using Ronion.DomainServicesContracts.Extensibility.Exports;
using Ronion.Entities;
using Ronion.LogisticsContracts;
using Ronion.LogisticsContracts.Extensibility.Imports;
using Ronion.MailSenderContract;
using Ronion.MailSenderContract.Extensibility.Imports;

namespace Ronion.DomainServices.BusinessLogic
{
    /// <summary>
    /// Order Business handling the business logic
    /// </summary>
    [BusinessLogicExport(typeof(IOrderService))]
    internal class OrderBusinessService : IOrderService, IBusinessService
    {
        [DataAccessImport]
        ICustomerRepository CustomerRepository { get; set; }

        [DataAccessImport]
        IOrderRepository OrderRepository { get; set; }

        [DataAccessImport]
        IInvoiceRepository InvoiceRepository { get; set; }

        [BillingImport]
        IBillingContract BillingService { get; set; }

        [LogisticsImport]
        ILogisticsContract LogisticsService { get; set; }

        [MailSenderImport]
        IMailSender MailSender { get; set; }

        /// <summary>
        /// Create new order in the system
        /// </summary>
        /// <param name="requestingUser">The user that creates the order</param>
        /// <param name="order">The actual customer's order</param>
        /// <returns>Id of the newly created order</returns>
        public MethodResult<int> CreateOrder(User requestingUser, Order order)
        {
            // create the order in the crm database
            var orderId = OrderRepository.Create(order);
            // bill the order in the billing system
            BillingService.BillOrder(order);
            // submit the order tologistics
            order.TrackingCode = LogisticsService.SendOrderToLogistics(order);
            // update the tracking code in crm
            OrderRepository.MarkOrderAsShipped(order);
            // send mail that the order is successfull
            MailSender.SendMail(new MailMessage(@"john@doe.com", order.Customer.Email, @"Order of [product] is successfull", @"SOME TEXT"));
            return new MethodResult<int>(orderId);
        }

        /// <summary>
        /// Return a list of order's customers
        /// </summary>
        /// <param name="requestingUser"></param>
        /// <param name="customer">The actual </param>
        /// <param name="queryOptions"></param>
        /// <returns></returns>
        public ListResult<Order> GetCustomerOrders(User requestingUser, Customer customer, QueryOptions queryOptions)
        {
            var orders = OrderRepository.GetCustomerOrders(customer, queryOptions);
            return new ListResult<Order>(orders);
        }

        /// <summary>
        /// Cancel order
        /// </summary>
        /// <param name="requestingUser">Requesting user that cancels the order</param>
        /// <param name="order">The order we want to cancel</param>
        /// <returns></returns>
        public MethodResult<bool> CancelOrder(User requestingUser, Order order)
        {
            var existingOrder = OrderRepository.Get(order.Id);
            // refund the order in the billing
            BillingService.CreateRefund(existingOrder.Customer, existingOrder.Total);
            // register the refund in the crm
            OrderRepository.CreateRefund(order.Customer, existingOrder.Total);
            // cancel the order in the logistics
            LogisticsService.CancelOrder(existingOrder.TrackingCode);
            // send mail that the order cancelation is successfull
            MailSender.SendMail(new MailMessage(@"john@doe.com", order.Customer.Email, @"Order canceled successfully", @"SOME TEXT"));
            return new MethodResult<bool>(true);
        }

        /// <summary>
        /// Return order delivery status
        /// </summary>
        /// <param name="requestingUser"></param>
        /// <param name="order">Information about the provided order</param>
        /// <returns>Order status with tracking log records</returns>
        public MethodResult<OrderTrackingStatus> GetOrderTrackingStatus(User requestingUser, Order order)
        {
            // cancel the order in the logistics
            var trackingStatus = LogisticsService.GetOrderTrackingStatus(order.TrackingCode);
            var orderTrackingStatus = new OrderTrackingStatus();
            orderTrackingStatus.AddTrackingLog(trackingStatus);
            return new MethodResult<OrderTrackingStatus>(orderTrackingStatus);
        }
    }
}