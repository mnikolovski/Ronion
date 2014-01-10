using Ronin.LoggerContract;

namespace Ronion.DomainServicesContracts.BaseContracts
{
    /// <summary>
    /// Service marker for exceptionh handling controller classes
    /// </summary>
    public interface IExceptionHandlingService : IService
    {
        ILogger Logger { get; set; }
    }
}
