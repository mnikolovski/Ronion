using System;
using System.ComponentModel.Composition;

namespace Ronion.MailSenderContract.Extensibility.Imports
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter, AllowMultiple = false, Inherited = false)]
    public class MailSenderImportAttribute : ImportAttribute
    {
        public MailSenderImportAttribute()
            : base()
        {
            base.RequiredCreationPolicy = RequiredCreationPolicy = CreationPolicy.NonShared;
        }
    }
}
