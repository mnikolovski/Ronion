using System;

namespace Ronion.Common.Base.Results
{
    /// <summary>
    /// Represent non void type result
    /// </summary>
    /// <typeparam name="T"></typeparam>
    [Serializable]
    public class MethodResult<T> : VoidResult
    {
        /// <summary>
        /// Result of a type
        /// </summary>
        public T Result { get; set; }

        /// <summary>
        /// CTOR
        /// </summary>
        public MethodResult(){}

        /// <summary>
        /// CTOR
        /// </summary>
        /// <param name="result">Execution result</param>
        public MethodResult(T result)
        {
            Result = result;
        }
    }
}
