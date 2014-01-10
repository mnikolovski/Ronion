using System;
using System.ComponentModel.Composition;
using Emit.ExtensibilityProvider.Extensibility;
using Ronion.DomainServicesContracts.BaseContracts;

namespace Ronion.DomainServicesContracts.Extensibility.Imports
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter, AllowMultiple = false, Inherited = false)]
    public class ValidationImportAttribute : ConstraintImportAttribute
    {
        public ValidationImportAttribute()
            : base(typeof(IValidationService))
        {
            base.RequiredCreationPolicy = RequiredCreationPolicy = CreationPolicy.NonShared;
        }
    }
}
