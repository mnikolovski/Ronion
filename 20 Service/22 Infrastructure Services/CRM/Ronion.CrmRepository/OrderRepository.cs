using System.Collections.Generic;
using Ronion.Common.Base.Repository;
using Ronion.CrmRepositoryContract;
using Ronion.CrmRepositoryContract.Extensibility.Exports;
using Ronion.Entities;

namespace Ronion.CrmRepository
{
    /// <summary>
    /// Order repo to our database
    /// </summary>
    [DataAccessExport(typeof(IOrderRepository))]
    internal class OrderRepository : BaseRepository<Order>, IOrderRepository
    {
        /// <summary>
        /// Once the order has been sent to logistcs mark it in our db
        /// </summary>
        /// <param name="order"></param>
        public void MarkOrderAsShipped(Order order)
        {
            
        }

        /// <summary>
        /// Create a refund for the actual order
        /// </summary>
        /// <param name="customer">Customer to be rufunded</param>
        /// <param name="refundAmount">Refund ammount</param>
        public void CreateRefund(Customer customer, decimal refundAmount)
        {
            
        }

        public List<Order> GetCustomerOrders(Customer customer, QueryOptions queryOptions)
        {
            return new List<Order>();
        }
    }
}
