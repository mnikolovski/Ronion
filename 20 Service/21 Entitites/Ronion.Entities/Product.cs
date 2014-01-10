namespace Ronion.Entities
{
    /// <summary>
    /// Represent ecommerce product
    /// </summary>
    public class Product
    {
        /// <summary>
        /// Name of the product we sell
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Short description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Product price
        /// </summary>
        public decimal Price { get; set; }
    }
}
