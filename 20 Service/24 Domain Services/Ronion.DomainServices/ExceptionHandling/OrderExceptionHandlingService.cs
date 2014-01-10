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
    /// Order Exception handling service wraps the calls and propage to the order validation service
    /// </summary>
    [EntryPointExport(typeof(IOrderService))]
    internal class OrderExceptionHandlingService : IOrderService, IEntryPointService, IExceptionHandlingService
    {
        [LoggerImport]
        public ILogger Logger { get; set; }

        [ValidationImport]
        IOrderService ValidationService { get; set; }

        /// <summary>
        /// Create new order in the system
        /// </summary>
        /// <param name="requestingUser">The user that creates the order</param>
        /// <param name="order">The actual customer's order</param>
        /// <returns>Id of the newly created order</returns>
        public MethodResult<int> CreateOrder(User requestingUser, Order order)
        {
            return this.WrapRequestResponseCall(() => ValidationService.CreateOrder(requestingUser, order));
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
            return this.WrapRequestResponseCall(() => ValidationService.GetCustomerOrders(requestingUser, customer, queryOptions));
        }

        /// <summary>
        /// Cancel order
        /// </summary>
        /// <param name="requestingUser">Requesting user that cancels the order</param>
        /// <param name="order">The order we want to cancel</param>
        /// <returns></returns>
        public MethodResult<bool> CancelOrder(User requestingUser, Order order)
        {
            return this.WrapRequestResponseCall(() => ValidationService.CancelOrder(requestingUser, order));
        }

        /// <summary>
        /// Return order delivery status
        /// </summary>
        /// <param name="requestingUser"></param>
        /// <param name="order">Information about the provided order</param>
        /// <returns>Order status with tracking log records</returns>
        public MethodResult<OrderTrackingStatus> GetOrderTrackingStatus(User requestingUser, Order order)
        {
            return this.WrapRequestResponseCall(() => ValidationService.GetOrderTrackingStatus(requestingUser, order));
        }
    }
}