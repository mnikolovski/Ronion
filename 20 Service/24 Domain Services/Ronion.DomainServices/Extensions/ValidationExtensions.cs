using System;

namespace Ronion.DomainServices.Extensions
{
    class ValidationExtensions
    {
        public static void Requires(bool predicate, string message)
        {
            if (!predicate)
            {
                throw new ArgumentException(message);
            }
        }
    }
}
