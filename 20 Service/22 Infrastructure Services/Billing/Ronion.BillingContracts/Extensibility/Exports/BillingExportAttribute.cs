using System;
using System.ComponentModel.Composition;

namespace Ronion.BillingContracts.Extensibility.Exports
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class BillingExportAttribute : ExportAttribute
    {
        /// <param name="exportType">Types that we export</param>
        public BillingExportAttribute(Type exportType)
            : base(exportType)
        {
            
        }
    }
}
