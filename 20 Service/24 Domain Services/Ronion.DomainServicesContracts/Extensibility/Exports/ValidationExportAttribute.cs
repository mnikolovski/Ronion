using System;
using Emit.ExtensibilityProvider.Extensibility;
using Ronion.DomainServicesContracts.BaseContracts;

namespace Ronion.DomainServicesContracts.Extensibility.Exports
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class ValidationExportAttribute : ConstraintExportAttribute
    {
        /// <param name="exportType">Types that we export</param>
        public ValidationExportAttribute(Type exportType)
            : base(exportType, typeof(IValidationService))
        {
            
        }
    }
}
