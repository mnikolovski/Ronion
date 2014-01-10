using System;
using System.ComponentModel.Composition;

namespace Ronion.MailSenderContract.Extensibility.Exports
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class MailSenderExportAttribute : ExportAttribute
    {
        /// <param name="exportType">Types that we export</param>
        public MailSenderExportAttribute(Type exportType)
            : base(exportType)
        {
            
        }
    }
}
