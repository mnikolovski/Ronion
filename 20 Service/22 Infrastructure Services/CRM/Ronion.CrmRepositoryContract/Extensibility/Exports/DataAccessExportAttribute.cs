using System;
using System.ComponentModel.Composition;

namespace Ronion.CrmRepositoryContract.Extensibility.Exports
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class DataAccessExportAttribute : ExportAttribute
    {
        /// <param name="exportType">Types that we export</param>
        public DataAccessExportAttribute(Type exportType)
            : base(exportType)
        {
            
        }
    }
}
