using System;

namespace Ronion.Common.Base.Exceptions
{
    /// <summary>
    /// Basic error data type used for additional customization
    /// </summary>
    [Serializable]
    public abstract class ErrorMessage : IErrorInfo
    {
        #region Implementation of IErrorInfo

        /// <summary>
        /// Error group
        /// </summary>
        public abstract string Group { get; protected set; }

        /// <summary>
        /// Error code
        /// </summary>
        public abstract string Code { get; protected set; }

        /// <summary>
        /// Fault message
        /// </summary>
        public abstract string FaultMessage { get; protected set; }

        /// <summary>
        /// Returns a string that represents the current object.
        /// </summary>
        /// <returns>
        /// A string that represents the current object.
        /// </returns>
        /// <filterpriority>2</filterpriority>
        public override string ToString()
        {
            return FaultMessage;
        }

        #endregion
    }
}
