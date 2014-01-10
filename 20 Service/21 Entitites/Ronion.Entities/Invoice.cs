using System.Collections.Generic;

namespace Ronion.Entities
{
    /// <summary>
    /// Represent system user
    /// </summary>
    public class Invoice
    {
        /// <summary>
        /// A customer to whom we invoice
        /// </summary>
        public Customer Customer { get; set; }

        /// <summary>
        /// Customer ordered products shown on the invoice
        /// </summary>
        public List<Product> Products { get; set; }

        /// <summary>
        /// Total invoice ammount
        /// </summary>
        public decimal Total { get; set; }
    }
}
