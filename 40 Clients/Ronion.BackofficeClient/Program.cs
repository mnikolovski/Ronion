using System;
using Ronion.DomainServiceInstance;
using Ronion.Entities;

namespace Ronion.BackofficeClient
{
    class Program
    {
        static void Main(string[] args)
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
            Console.ReadKey();
        }
    }
}
