using System;
using Ronion.Common.Base.Exceptions;

namespace Ronion.DomainServices.Errors
{
    /// <summary>
    /// Represent a domain service error
    /// </summary>
    public sealed class DomainServiceException : ErrorMessage
    {
        private string _faultMessage = "";

        public DomainServiceException(Exception exception)
        {
            _faultMessage = exception.Message;
            _faultMessage = string.Format("{0}{2}   at {1}{2}",
                                          FaultMessage,
                                          exception.StackTrace,
                                          Environment.NewLine);
        }

        /// <summary>
        /// In which error group the exception belongs to
        /// </summary>
        public override string Group
        {
            get { return @"GE"; }
            protected set {  }
        }

        /// <summary>
        /// What is the error code of the exception
        /// </summary>
        public override string Code
        {
            get { return @"10100"; }
            protected set { }
        }

        public override string FaultMessage
        {
            get
            {
                return _faultMessage;
            }
            protected set
            {
                _faultMessage = value;
            }
        }
    }
}
