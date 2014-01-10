using System;
using Ronion.BillingContracts;
using Ronion.BillingContracts.Extensibility.Exports;
using Ronion.Entities;

namespace Ronion.AuthorizeNetBilling
{
    [BillingExport(typeof(IBillingContract))]
    internal class AuthorizeNetService : IBillingContract
    {
        /// <summary>
        /// Bill the order in the billing system
        /// </summary>
        /// <param name="order">The order that needs to be billed</param>
        /// <returns>External billing id of the order</returns>
        public string BillOrder(Order order)
        {
            // create order to authorize net service
            return DateTime.Now.ToString(@"yyyyMMddHHmmssffff");
        }

        /// <summary>
        /// Create a refund for the actual order
        /// </summary>
        /// <param name="customer">Customer to be rufunded</param>
        /// <param name="refundAmount">Refund ammount</param>
        public void CreateRefund(Customer customer, decimal refundAmount)
        {
            // do some fancy web service calls
        }
    }
}
