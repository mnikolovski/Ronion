using System.Collections.Generic;
using Ronion.Common.Base.Repository;
using Ronion.CrmRepositoryContract;

namespace Ronion.CrmRepository
{
    /// <summary>
    /// Your data access implementation using: EF, NHibernate, PetaPoco, ADO.NET...
    /// </summary>
    /// <typeparam name="T"></typeparam>
    internal class BaseRepository<T> : IBaseRepository<T>
    {
        /// <summary>
        /// Create an entity
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public int Create(T entity)
        {
            return -1;
        }

        /// <summary>
        /// Get an entity by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public T Get(int id)
        {
            return default(T);
        }

        /// <summary>
        /// Delete an entity
        /// </summary>
        /// <param name="id"></param>
        public void Delete(int id)
        {
            
        }

        /// <summary>
        /// Delete an entity
        /// </summary>
        /// <param name="entity"></param>
        public void Delete(T entity)
        {
            
        }

        /// <summary>
        /// Return list of entities
        /// </summary>
        /// <param name="queryOptions"></param>
        /// <returns></returns>
        public List<T> GetAll(QueryOptions queryOptions)
        {
            return new List<T>();
        }
    }
}
