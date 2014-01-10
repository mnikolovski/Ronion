using System;
using System.Collections.Generic;
using Ronion.Common.Base.Exceptions;

namespace Ronion.Common.Base.Results
{
    /// <summary>
    /// Represent result of type void
    /// </summary>
    [Serializable]
    public class VoidResult
    {
        /// <summary>
        /// CTOR
        /// </summary>
        public VoidResult()
        {
            ErrorMessages = new List<ErrorMessage>();
        }

        /// <summary>
        /// Indicate that the call has been faulted
        /// </summary>
        public bool IsFaulted { get; set; }

        /// <summary>
        /// Indicate that the call has been faulted due to a system error
        /// </summary>
        public bool IsSystemFault { get; set; }

        /// <summary>
        /// Error messages returned from the execution call
        /// </summary>
        public List<ErrorMessage> ErrorMessages { get; set; }
    }
}
