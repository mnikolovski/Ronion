using System;
using Ronion.Entities;
using Ronion.LogisticsContracts;
using Ronion.LogisticsContracts.Extensibility.Exports;

namespace Ronion.UpsLogistics
{
    [LogisticsExport(typeof(ILogisticsContract))]
    internal class UpsService : ILogisticsContract
    {
        readonly Random _mRandom = new Random();

        /// <summary>
        /// Send order to logistics so we can deliver it to the customer
        /// </summary>
        /// <param name="order">The order that needs to be delivered</param>
        /// <returns>Tracking code</returns>
        public string SendOrderToLogistics(Order order)
        {
            return DateTime.Now.ToString(@"yyyyMMddHHmmssffff");
        }

        /// <summary>
        /// Cancel order that was sent to logistics
        /// </summary>
        /// <param name="orderTrackingCode">The order's tracking code for the order we want to cancel</param>
        /// <returns></returns>
        public bool CancelOrder(string orderTrackingCode)
        {
            bool result = Convert.ToBoolean(_mRandom.Next() % 2);
            return result;
        }

        /// <summary>
        /// Return order tracking status from logistics
        /// </summary>
        /// <param name="trackingCode"></param>
        /// <returns></returns>
        public string GetOrderTrackingStatus(string trackingCode)
        {
            return DateTime.Now.ToString(@"yyyyMMddHHmmssffff");
        }
    }
}
