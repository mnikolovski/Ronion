using System.Collections.Generic;
using Ronion.Entities;

namespace Ronion.CrmRepositoryContract
{
    /// <summary>
    /// Represents user repository
    /// </summary>
    public interface IUserRepository : IBaseRepository<User>
    {
        /// <summary>
        /// Check if the user exist in the database
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        bool IsRegisteredUser(User user);
    }
}
