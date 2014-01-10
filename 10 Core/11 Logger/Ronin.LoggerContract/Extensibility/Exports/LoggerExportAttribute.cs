using System;
using System.ComponentModel.Composition;

namespace Ronin.LoggerContract.Extensibility.Exports
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class LoggerExportAttribute : ExportAttribute
    {
        /// <param name="exportType">Types that we export</param>er
        public LoggerExportAttribute(Type exportType)
            : base(exportType)
        {
            
        }
    }
}
