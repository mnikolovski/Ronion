using Ronion.Entities;

namespace Ronion.CrmRepositoryContract
{
    /// <summary>
    /// Represents product repository
    /// </summary>
    public interface IProductRepository : IBaseRepository<Product>
    {
        /// <summary>
        /// Set new tags to a product
        /// </summary>
        /// <param name="product"></param>
        /// <param name="tags"></param>
        void UpdateProductTags(Product product, string[] tags);
    }
}
