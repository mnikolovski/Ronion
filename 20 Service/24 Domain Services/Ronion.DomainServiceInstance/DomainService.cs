using Emit.ExtensibilityProvider.Concrete;
using Ronion.DomainServicesContracts;
using Ronion.DomainServicesContracts.BaseContracts;

namespace Ronion.DomainServiceInstance
{
    public class DomainService
    {
        public static readonly DomainService Instance = new DomainService();
        private static SystemBootstrapper _bootstrapper;

        #region Order controller

        public IOrderService OrderService
        {
            get
            {
                return _bootstrapper.GetInstance<IOrderService>(new[] { typeof(IEntryPointService) });
            }
        }

        #endregion

        #region Invoice controller

        public IInvoiceService InvoiceService
        {
            get
            {
                return _bootstrapper.GetInstance<IInvoiceService>(new[] { typeof(IEntryPointService) });
            }
        }

        #endregion

        private DomainService()
        {
            _bootstrapper = new SystemBootstrapper();
            _bootstrapper.Execute(this);
        }

        /// <summary>
        /// Start initializing the container (by invoking a method static constructor will be called)
        /// </summary>
        public static void Init()
        {

        }
    }
}
