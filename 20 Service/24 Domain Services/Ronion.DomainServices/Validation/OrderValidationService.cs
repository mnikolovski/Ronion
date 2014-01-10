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
    /// Order validation service validate the calls data and propage to the order security service
    /// </summary>
    [ValidationExport(typeof(IOrderService))]
    internal class OrderValidationService : IOrderService, IValidationService
    {
        [SecurityImport]
        IOrderService SecurityService { get; set; }

        /// <summary>
        /// Create new order in the system
        /// </summary>
        /// <param name="requestingUser">The user that creates the order</param>
        /// <param name="order">The actual customer's order</param>
        /// <returns>Id of the newly created order</returns>
        public MethodResult<int> CreateOrder(User requestingUser, Order order)
        {
            // do validation of the call
            ValidationExtensions.Requires(requestingUser != null, "requestingUser cannot be null.");
            ValidationExtensions.Requires(requestingUser.Email != null, "requestingUser.Email cannot be null.");
            ValidationExtensions.Requires(order != null, "order cannot be null.");
            ValidationExtensions.Requires(order.Customer != null, "order.Customer cannot be null.");
            ValidationExtensions.Requires(order.Customer.Email != null, "order.Customer.Email cannot be null.");
            return SecurityService.CreateOrder(requestingUser, order);
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
            // do validation of the call
            ValidationExtensions.Requires(requestingUser != null, "requestingUser cannot be null.");
            ValidationExtensions.Requires(customer != null, "customer cannot be null.");
            return SecurityService.GetCustomerOrders(requestingUser, customer, queryOptions);
        }

        /// <summary>
        /// Cancel order
        /// </summary>
        /// <param name="requestingUser">Requesting user that cancels the order</param>
        /// <param name="order">The order we want to cancel</param>
        /// <returns></returns>
        public MethodResult<bool> CancelOrder(User requestingUser, Order order)
        {
            // do validation of the call
            ValidationExtensions.Requires(requestingUser != null, "requestingUser cannot be null.");
            ValidationExtensions.Requires(order != null, "order cannot be null.");
            return SecurityService.CancelOrder(requestingUser, order);
        }

        /// <summary>
        /// Return order delivery status
        /// </summary>
        /// <param name="requestingUser"></param>
        /// <param name="order">Information about the provided order</param>
        /// <returns>Order status with tracking log records</returns>
        public MethodResult<OrderTrackingStatus> GetOrderTrackingStatus(User requestingUser, Order order)
        {
            // do validation of the call
            ValidationExtensions.Requires(requestingUser != null, "requestingUser cannot be null.");
            ValidationExtensions.Requires(order != null, "order cannot be null.");
            return SecurityService.GetOrderTrackingStatus(requestingUser, order);
        }
    }
}