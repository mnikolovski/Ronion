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
    /// Order security service check the security of the calls and propage to the order business service
    /// </summary>
    [SecurityExport(typeof(IOrderService))]
    internal class OrderSecurityService : IOrderService, ISecurityService
    {
        [DataAccessImport]
        IUserRepository UserRepository { get; set; }

        [BusinessLogicImport]
        IOrderService BusinessService { get; set; }

        /// <summary>
        /// Create new order in the system
        /// </summary>
        /// <param name="requestingUser">The user that creates the order</param>
        /// <param name="order">The actual customer's order</param>
        /// <returns>Id of the newly created order</returns>
        public MethodResult<int> CreateOrder(User requestingUser, Order order)
        {
            var isExistingUser = UserRepository.IsRegisteredUser(requestingUser);
            ValidationExtensions.Requires(isExistingUser, "Invoice can be created only for existing users");
            // check security...
            return BusinessService.CreateOrder(requestingUser, order);
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
            var isExistingUser = UserRepository.IsRegisteredUser(requestingUser);
            ValidationExtensions.Requires(isExistingUser, "Invoice can be created only for existing users");
            // check security...
            return BusinessService.GetCustomerOrders(requestingUser, customer, queryOptions);
        }

        /// <summary>
        /// Cancel order
        /// </summary>
        /// <param name="requestingUser">Requesting user that cancels the order</param>
        /// <param name="order">The order we want to cancel</param>
        /// <returns></returns>
        public MethodResult<bool> CancelOrder(User requestingUser, Order order)
        {
            var isExistingUser = UserRepository.IsRegisteredUser(requestingUser);
            ValidationExtensions.Requires(isExistingUser, "Invoice can be created only for existing users");
            // check security...
            return BusinessService.CancelOrder(requestingUser, order);
        }

        /// <summary>
        /// Return order delivery status
        /// </summary>
        /// <param name="requestingUser"></param>
        /// <param name="order">Information about the provided order</param>
        /// <returns>Order status with tracking log records</returns>
        public MethodResult<OrderTrackingStatus> GetOrderTrackingStatus(User requestingUser, Order order)
        {
            var isExistingUser = UserRepository.IsRegisteredUser(requestingUser);
            ValidationExtensions.Requires(isExistingUser, "Invoice can be created only for existing users");
            // check security...
            return BusinessService.GetOrderTrackingStatus(requestingUser, order);
        }
    }
}