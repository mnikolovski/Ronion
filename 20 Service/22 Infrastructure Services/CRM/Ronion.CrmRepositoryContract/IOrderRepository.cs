using System.Collections.Generic;
using Ronion.Common.Base.Repository;
using Ronion.Entities;

namespace Ronion.CrmRepositoryContract
{
    /// <summary>
    /// Represents order repository
    /// </summary>
    public interface IOrderRepository : IBaseRepository<Order>
    {
        /// <summary>
        /// Once the order has been sent to logistcs mark it in our db
        /// </summary>
        /// <param name="order"></param>
        void MarkOrderAsShipped(Order order);

        /// <summary>
        /// Create a refund for the actual order
        /// </summary>
        /// <param name="customer">Customer to be rufunded</param>
        /// <param name="refundAmount">Refund ammount</param>
        void CreateRefund(Customer customer, decimal refundAmount);

        /// <summary>
        /// Return a list of customer orders
        /// </summary>
        /// <param name="customer"></param>
        /// <param name="queryOptions"></param>
        /// <returns></returns>
        List<Order> GetCustomerOrders(Customer customer, QueryOptions queryOptions);
    }
}
