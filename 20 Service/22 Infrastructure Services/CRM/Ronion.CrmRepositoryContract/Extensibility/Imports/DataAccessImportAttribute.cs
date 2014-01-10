using System;
using System.ComponentModel.Composition;

namespace Ronion.CrmRepositoryContract.Extensibility.Imports
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter, AllowMultiple = false, Inherited = false)]
    public class DataAccessImportAttribute : ImportAttribute
    {
        public DataAccessImportAttribute()
            : base()
        {
            base.RequiredCreationPolicy = RequiredCreationPolicy = CreationPolicy.NonShared;
        }
    }
}
