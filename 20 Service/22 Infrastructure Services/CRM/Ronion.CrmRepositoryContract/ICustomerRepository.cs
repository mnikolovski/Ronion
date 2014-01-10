using System.Collections.Generic;
using Ronion.Entities;

namespace Ronion.CrmRepositoryContract
{
    /// <summary>
    /// Represents customer repository
    /// </summary>
    public interface ICustomerRepository : IBaseRepository<Customer>
    { 
        /// <summary>
        /// Updates the ratingof an existing customer
        /// </summary>
        /// <param name="customer"></param>
        /// <param name="rating"></param>
        void UpdateCustomerRating(Customer customer, decimal rating);

        /// <summary>
        /// Return a list of customers that satissfies the rating from-to condition
        /// </summary>
        /// <param name="ratingFrom"></param>
        /// <param name="ratingTo"></param>
        /// <returns></returns>
        List<Customer> GetCustomerByRating(decimal ratingFrom, decimal ratingTo); 

        /// <summary>
        /// Ban a customer in the database
        /// </summary>
        /// <param name="customer"></param>
        void BanCustomer(Customer customer);
    }
}
