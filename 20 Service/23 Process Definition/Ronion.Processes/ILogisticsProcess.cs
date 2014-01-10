using Ronion.Common.Base.Results;
using Ronion.Entities;

namespace Ronion.Processes
{
    public interface ILogisticsProcess
    {
        /// <summary>
        /// Return order delivery status
        /// </summary>
        /// <param name="requestingUser"></param>
        /// <param name="order">Information about the provided order</param>
        /// <returns>Order status with tracking log records</returns>
        MethodResult<OrderTrackingStatus> GetOrderTrackingStatus(User requestingUser, Order order);
    }
}
