using Ronion.CrmRepositoryContract;
using Ronion.CrmRepositoryContract.Extensibility.Exports;
using Ronion.Entities;

namespace Ronion.CrmRepository
{
    /// <summary>
    /// Product repo to our database
    /// </summary>
    [DataAccessExport(typeof(IProductRepository))]
    internal class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        /// <summary>
        /// Set new tags to a product
        /// </summary>
        /// <param name="product"></param>
        /// <param name="tags"></param>
        public void UpdateProductTags(Product product, string[] tags)
        {
            
        }
    }
}
