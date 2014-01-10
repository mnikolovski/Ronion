using System.Collections.Generic;
using Ronion.Common.Base.Repository;

namespace Ronion.CrmRepositoryContract
{
    /// <summary>
    /// Represents base repository
    /// </summary>
    public interface IBaseRepository<T>
    {
        /// <summary>
        /// Create an entity
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        int Create(T entity);

        /// <summary>
        /// Get an entity by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        T Get(int id);

        /// <summary>
        /// Return list of entities
        /// </summary>
        /// <param name="queryOptions"></param>
        /// <returns></returns>
        List<T> GetAll(QueryOptions queryOptions);

        /// <summary>
        /// Delete an entity
        /// </summary>
        /// <param name="id"></param>
        void Delete(int id);

        /// <summary>
        /// Delete an entity
        /// </summary>
        /// <param name="entity"></param>
        void Delete(T entity);
    }
}
