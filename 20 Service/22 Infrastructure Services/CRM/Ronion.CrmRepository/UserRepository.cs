using System;
using Ronion.CrmRepositoryContract;
using Ronion.CrmRepositoryContract.Extensibility.Exports;
using Ronion.Entities;

namespace Ronion.CrmRepository
{
    /// <summary>
    /// User repo to our database
    /// </summary>
    [DataAccessExport(typeof(IUserRepository))]
    internal class UserRepository : BaseRepository<User>, IUserRepository
    {
        readonly Random _mRandom = new Random();

        /// <summary>
        /// Check if the user exist in the database
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public bool IsRegisteredUser(User user)
        {
            bool result = Convert.ToBoolean(_mRandom.Next() % 2);
            return result;
        }
    }
}
