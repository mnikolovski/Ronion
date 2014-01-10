using System.Collections.Generic;
using Ronion.CrmRepositoryContract;
using Ronion.CrmRepositoryContract.Extensibility.Exports;
using Ronion.Entities;

namespace Ronion.CrmRepository
{
    /// <summary>
    /// Customer repo to our database
    /// </summary>
    [DataAccessExport(typeof(ICustomerRepository))]
    internal class CustomerRepository : BaseRepository<Customer>, ICustomerRepository
    {
        /// <summary>
        /// Updates the ratingof an existing customer
        /// </summary>
        /// <param name="customer"></param>
        /// <param name="rating"></param>
        public void UpdateCustomerRating(Customer customer, decimal rating)
        {
            
        }

        /// <summary>
        /// Return a list of customers that satissfies the rating from-to condition
        /// </summary>
        /// <param name="ratingFrom"></param>
        /// <param name="ratingTo"></param>
        /// <returns></returns>
        public List<Customer> GetCustomerByRating(decimal ratingFrom, decimal ratingTo)
        {
            return new List<Customer>();
        }

        /// <summary>
        /// Ban a customer in the database
        /// </summary>
        /// <param name="customer"></param>
        public void BanCustomer(Customer customer)
        {
            
        }
    }
}
