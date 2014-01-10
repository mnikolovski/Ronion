using System.Collections.Generic;

namespace Ronion.Entities
{
    /// <summary>
    /// Represent tracking log for an order
    /// </summary>
    public class OrderTrackingStatus
    {
        /// <summary>
        /// Tracking log records 
        /// </summary>
        public List<string> TrackingLines { get; set; }

        /// <summary>
        /// CTOR
        /// </summary>
        public OrderTrackingStatus()
        {
            TrackingLines = new List<string>();
        }

        public void AddTrackingLog(string trackingInfo)
        {
            TrackingLines.Add(trackingInfo);
        }
    }
}
