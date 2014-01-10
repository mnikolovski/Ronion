using Ronion.Entities;

namespace Ronion.LogisticsContracts
{
    /// <summary>
    /// Represents logistics contract for delivering orders to customers
    /// </summary>
    public interface ILogisticsContract
    {
        /// <summary>
        /// Send order to logistics so we can deliver it to the customer
        /// </summary>
        /// <param name="order">The order that needs to be delivered</param>
        /// <returns>Tracking code</returns>
        string SendOrderToLogistics(Order order);

        /// <summary>
        /// Cancel order that was sent to logistics
        /// </summary>
        /// <param name="orderTrackingCode">The order's tracking code for the order we want to cancel</param>
        /// <returns></returns>
        bool CancelOrder(string orderTrackingCode);

        /// <summary>
        /// Return order tracking status from logistics
        /// </summary>
        /// <param name="trackingCode"></param>
        /// <returns></returns>
        string GetOrderTrackingStatus(string trackingCode);
    }
}
