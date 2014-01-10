using Ronion.DomainServicesContracts.BaseContracts;
using Ronion.Processes;

namespace Ronion.DomainServicesContracts
{
    /// <summary>
    /// Represent contract for invoice domain service
    /// </summary>
    public interface IInvoiceService : IInvoiceProcess, IService
    {
    }
}
