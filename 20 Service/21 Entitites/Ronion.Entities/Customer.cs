namespace Ronion.Entities
{
    /// <summary>
    /// Represent a customer
    /// </summary>
    public class Customer : User
    {
        /// <summary>
        /// Customers's Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Customers' surname
        /// </summary>
        public string Surname { get; set; }
    }
}
