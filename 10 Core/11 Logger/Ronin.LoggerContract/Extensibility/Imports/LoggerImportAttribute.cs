using System;
using System.ComponentModel.Composition;

namespace Ronin.LoggerContract.Extensibility.Imports
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter, AllowMultiple = false, Inherited = false)]
    public class LoggerImportAttribute : ImportAttribute
    {
        public LoggerImportAttribute()
            : base()
        {
            base.RequiredCreationPolicy = RequiredCreationPolicy = CreationPolicy.NonShared;
        }
    }
}
