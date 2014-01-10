using System;
using System.Collections.Generic;

namespace Ronion.Common.Base.Results
{
    /// <summary>
    /// Represent a list result
    /// </summary>
    /// <typeparam name="T"></typeparam>
    [Serializable]
    public class ListResult<T> : VoidResult
    {
        /// <summary>
        /// List result from a type
        /// </summary>
        public new List<T> Result { get; set; }

        /// <summary>
        /// CTOR
        /// </summary>
        public ListResult():this(null) {}

        /// <summary>
        /// CTOR
        /// </summary>
        /// <param name="result">Return result from call</param>
        public ListResult(List<T> result = null)
        {
            Result = result ?? new List<T>();
        }
    }
}
