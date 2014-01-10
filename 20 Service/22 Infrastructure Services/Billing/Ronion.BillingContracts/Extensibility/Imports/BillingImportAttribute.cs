using System;
using System.ComponentModel.Composition;

namespace Ronion.BillingContracts.Extensibility.Imports
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter, AllowMultiple = false, Inherited = false)]
    public class BillingImportAttribute : ImportAttribute
    {
        public BillingImportAttribute()
            : base()
        {
            base.RequiredCreationPolicy = RequiredCreationPolicy = CreationPolicy.NonShared;
        }
    }
}
