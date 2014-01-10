using System.Collections.Generic;

namespace Ronion.Entities
{
    /// <summary>
    /// Represent a cusomer order
    /// </summary>
    public class Order
    {
        /// <summary>
        /// Id of the order
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// A customer that create the order
        /// </summary>
        public Customer Customer { get; set; }

        /// <summary>
        /// List of products the customer ordered
        /// </summary>
        public List<Product> Products { get; set; }

        /// <summary>
        /// Total order ammount
        /// </summary>
        public decimal Total { get; set; }

        /// <summary>
        /// Order tracking code
        /// </summary>
        public string TrackingCode { get; set; }
    }
}
