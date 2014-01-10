using System;
using Emit.ExtensibilityProvider.Extensibility;
using Ronion.DomainServicesContracts.BaseContracts;

namespace Ronion.DomainServicesContracts.Extensibility.Exports
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class EntryPointExportAttribute : ConstraintExportAttribute
    {
        /// <param name="exportType">Types that we export</param>
        public EntryPointExportAttribute(Type exportType)
            : base(exportType, typeof(IEntryPointService))
        {
            
        }
    }
}
