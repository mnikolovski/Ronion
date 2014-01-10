using System.Web.Mvc;
using Ronion.DomainServiceInstance;
using Ronion.Entities;

namespace Ronion.WebShopClient.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            // use the domain services as a black box in any consuming client. Just like using an SDK. 
            DomainService.Instance.OrderService.CreateOrder(new User(), new Order());
            var orderId = DomainService.Instance.OrderService.CreateOrder(new User(), new Order()
            {
                Customer = new Customer()
                {
                    Email = @"some@user.com"
                }
            });
            var invoiceId = DomainService.Instance.InvoiceService.CreateInvoice(new User(), new Invoice());
            return View();
        }

    }
}
