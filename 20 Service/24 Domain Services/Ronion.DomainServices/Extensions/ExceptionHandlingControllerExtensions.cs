using System;
using Ronion.Common.Base.Results;
using Ronion.DomainServices.Errors;
using Ronion.DomainServicesContracts.BaseContracts;

namespace Ronion.DomainServices.Extensions
{
    internal static class ExceptionHandlingControllerExtensions
    {
        /// <summary>
        /// Wrap reqest/response calls
        /// </summary>
        /// <typeparam name="TResponse"></typeparam>
        /// <param name="ehci"></param>
        /// <param name="action"></param>
        /// <returns></returns>
        internal static TResponse WrapRequestResponseCall<TResponse>(this IExceptionHandlingService ehci, Func<TResponse> action) where TResponse : VoidResult, new()
        {
            var _response = new TResponse();

            try
            {
                _response = action();
            }
            /* Add custom exceptions handling, system exception, integration, database... 
            catch (EntityException _enex)
            {
                Log(_enex, ehci, _response);
            }
            catch (DbUpdateConcurrencyException _dbuce)
            {
                Log(_dbuce, ehci, _response);
            }
            catch (DbUpdateException _dbux)
            {
                Log(_dbux, ehci, _response);
            }
            catch (DataException _dex)
            {
                Log(_dex, ehci, _response);
            }
            catch (MongoConnectionException _mcex)
            {
                Log(_mcex, ehci, _response);
            }
            */
            catch (Exception _ex)
            {
                Log(_ex, ehci, _response);
            }

            return _response;
        }

        /// <summary>
        /// Make the given response faulted and extract error messages from exception
        /// </summary>
        /// <typeparam name="TResponse"></typeparam>
        /// <typeparam name="TException"></typeparam>
        /// <param name="ehci"></param>
        /// <param name="response"></param>
        /// <param name="ex"></param>
        private static void CreateFaultedResponse<TResponse, TException>(this IExceptionHandlingService ehci, TResponse response, TException ex)
            where TResponse : VoidResult
            where TException : Exception
        {
            // fault the response
            response.IsFaulted = true;
            // and create general error message
            var _errorMessage = new DomainServiceException(ex);
            // add it to the response
            response.ErrorMessages.Add(_errorMessage);
        }

        /// <summary>
        /// Log the exception
        /// </summary>
        /// <typeparam name="TException"></typeparam>
        /// <typeparam name="TResponse"></typeparam>
        /// <param name="ex"></param>
        /// <param name="ehci"></param>
        /// <param name="response"></param>
        private static void Log<TException, TResponse>(TException ex, IExceptionHandlingService ehci, TResponse response)
            where TException : Exception, new()
            where TResponse : VoidResult, new()
        {
            Exception innerException = ex.InnerException;
            var hasInner = innerException != null;
            while (hasInner)
            {
                if (innerException.InnerException == null)
                {
                    hasInner = false;
                }
                else
                {
                    innerException = innerException.InnerException;
                }
            }
            if (innerException != null)
            {
                ehci.Logger.Log(innerException);
            }
            else
            {
                ehci.Logger.Log(ex);
            }
            response.IsSystemFault = true;
            CreateFaultedResponse(ehci, response, ex);
        }
    }
}
