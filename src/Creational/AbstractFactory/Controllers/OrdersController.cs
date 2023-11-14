using AbstractFactory.Core;
using AbstractFactory.Infrastructure;
using AbstractFactory.Infrastructure.Payments;
using Microsoft.AspNetCore.Mvc;

namespace AbstractFactory.Controllers
{
    public class OrdersController : ControllerBase
    {
        private readonly IPaymentServiceFactory _paymentServiceFactory;
        public OrdersController(IPaymentServiceFactory paymentServiceFactory)
        {
            _paymentServiceFactory = paymentServiceFactory;
        }

        [HttpPost]
        public IActionResult Post(OrderInputModel model)
        {
            if(model.IsInternational) 
            {
            
            }
            else
            {

            }

            return NoContent();
        }

        [HttpPost]
        public IActionResult Post_AbstractFactory(OrderInputModel model, 
            [FromServices] InternationalOrderAbstractFactory internationalOrderAbstractFactory,
            [FromServices] NationalOrderAbstractFactory nationalOrderAbstractFactory)
        {
            IOrderAbstractFactory orderAbstractFactory;


            if (model.IsInternational)
            {
                orderAbstractFactory = internationalOrderAbstractFactory;
            }
            else
            {
                orderAbstractFactory = nationalOrderAbstractFactory;
            }

            var paymentResult = orderAbstractFactory
                .GetPaymentService(model.PaymentInfo)
                .Process(model);

            orderAbstractFactory
                .GetDeliveryService()
                .Deliver(model);

            return NoContent();
        }
    }
}
