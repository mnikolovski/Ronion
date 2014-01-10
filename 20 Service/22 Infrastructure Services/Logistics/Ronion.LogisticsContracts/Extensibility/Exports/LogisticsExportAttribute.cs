using System;
using System.ComponentModel.Composition;

namespace Ronion.LogisticsContracts.Extensibility.Exports
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class LogisticsExportAttribute : ExportAttribute
    {
        /// <param name="exportType">Types that we export</param>
        public LogisticsExportAttribute(Type exportType)
            : base(exportType)
        {
            
        }
    }
}
