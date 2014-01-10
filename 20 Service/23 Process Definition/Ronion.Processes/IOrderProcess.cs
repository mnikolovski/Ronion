using Ronion.Common.Base.Repository;
using Ronion.Common.Base.Results;
using Ronion.Entities;

namespace Ronion.Processes
{
    public interface IOrderProcess
    {
        /// <summary>
        /// Create new order in the system
        /// </summary>
        /// <param name="requestingUser">The user that creates the order</param>
        /// <param name="order">The actual customer's order</param>
        /// <returns>Id of the newly created order</returns>
        MethodResult<int> CreateOrder(User requestingUser, Order order);

        /// <summary>
        /// Return a list of order's customers
        /// </summary>
        /// <param name="requestingUser"></param>
        /// <param name="customer">The actual </param>
        /// <param name="queryOptions"></param>
        /// <returns></returns>
        ListResult<Order> GetCustomerOrders(User requestingUser, Customer customer, QueryOptions queryOptions);

        /// <summary>
        /// Cancel order
        /// </summary>
        /// <param name="requestingUser">Requesting user that cancels the order</param>
        /// <param name="order">The order we want to cancel</param>
        /// <returns></returns>
        MethodResult<bool> CancelOrder(User requestingUser, Order order);
    }
}
