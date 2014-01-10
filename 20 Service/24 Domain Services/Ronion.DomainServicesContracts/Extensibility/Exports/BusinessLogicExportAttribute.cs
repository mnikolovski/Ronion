using System;
using Emit.ExtensibilityProvider.Extensibility;
using Ronion.DomainServicesContracts.BaseContracts;

namespace Ronion.DomainServicesContracts.Extensibility.Exports
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class BusinessLogicExportAttribute : ConstraintExportAttribute
    {
        /// <param name="exportType">Types that we export</param>
        public BusinessLogicExportAttribute(Type exportType)
            : base(exportType, typeof(IBusinessService))
        {
            
        } 
    }
}
