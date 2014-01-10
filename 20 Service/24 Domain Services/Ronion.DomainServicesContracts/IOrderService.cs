using Ronion.DomainServicesContracts.BaseContracts;
using Ronion.Processes;

namespace Ronion.DomainServicesContracts
{
    /// <summary>
    /// Represent contract for order domain service
    /// </summary>
    public interface IOrderService : IOrderProcess, ILogisticsProcess, IService
    {
    }
}
