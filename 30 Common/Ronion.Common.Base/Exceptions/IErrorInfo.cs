namespace Ronion.Common.Base.Exceptions
{
    /// <summary>
    /// Represent an error data type
    /// </summary>
    public interface IErrorInfo
    {
        /// <summary>
        /// Error group
        /// </summary>
        string Group { get; }

        /// <summary>
        /// Error code
        /// </summary>
        string Code { get; }

        /// <summary>
        /// Fault message
        /// </summary>
        string FaultMessage { get; }
    }
}
