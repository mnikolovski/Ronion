using System;
using System.ComponentModel.Composition;

namespace Ronion.LogisticsContracts.Extensibility.Imports
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter, AllowMultiple = false, Inherited = false)]
    public class LogisticsImportAttribute : ImportAttribute
    {
        public LogisticsImportAttribute()
            : base()
        {
            base.RequiredCreationPolicy = RequiredCreationPolicy = CreationPolicy.NonShared;
        }
    }
}
