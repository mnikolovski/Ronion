using Ronion.Entities;

namespace Ronion.BillingContracts
{
    /// <summary>
    /// Represents billing contract for billing orders to customers
    /// </summary>
    public interface IBillingContract
    {
        /// <summary>
        /// Bill the order in the billing system
        /// </summary>
        /// <param name="order">The order that needs to be billed</param>
        /// <returns>External billing id of the order</returns>
        string BillOrder(Order order);

        /// <summary>
        /// Create a refund for the actual order
        /// </summary>
        /// <param name="customer">Customer to be rufunded</param>
        /// <param name="refundAmount">Refund ammount</param>
        void CreateRefund(Customer customer, decimal refundAmount);
    }
}
