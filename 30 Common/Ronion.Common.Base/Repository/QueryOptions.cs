using System;

namespace Ronion.Common.Base.Repository
{
    /// <summary>
    /// Data loading query options
    /// </summary>
    [Serializable]
    public class QueryOptions
    {
        /// <summary>
        /// Default page
        /// </summary>
        public static readonly int DefaultPage = 1;

        /// <summary>
        /// Page to be retrieved
        /// </summary>
        public int Page { get; set; }

        /// <summary>
        /// Pagesize - result count
        /// </summary>
        public int PageSize { get; set; }
    }
}
