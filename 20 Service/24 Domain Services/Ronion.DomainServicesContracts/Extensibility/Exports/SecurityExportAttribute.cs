using System;
using Emit.ExtensibilityProvider.Extensibility;
using Ronion.DomainServicesContracts.BaseContracts;

namespace Ronion.DomainServicesContracts.Extensibility.Exports
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class SecurityExportAttribute : ConstraintExportAttribute
    {
        /// <param name="exportType">Types that we export</param>
        public SecurityExportAttribute(Type exportType)
            : base(exportType, typeof(ISecurityService))
        {
            
        }
    }
}
