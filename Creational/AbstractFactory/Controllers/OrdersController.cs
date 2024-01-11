using AbstractFactory.Enums;
using AbstractFactory.Infrastructure;
using AbstractFactory.Infrastructure.Deliveries;
using AbstractFactory.Infrastructure.Factory;
using AbstractFactory.Models;
using Microsoft.AspNetCore.Mvc;

namespace AbstractFactory.Controllers
{
    [ApiController]
    [Route("api/orders")]
    public class OrdersController : ControllerBase
    {
        private readonly ILogger<OrdersController> _logger;
        private readonly IPaymentServiceFactory _paymentServiceFactory;

        public OrdersController(ILogger<OrdersController> logger, IPaymentServiceFactory paymentServiceFactory)
        {
            _logger = logger;
            _paymentServiceFactory = paymentServiceFactory;
        }

        [HttpPost]
        public IActionResult Post_V1(OrderInputModel model)
        {
            if(model.IsInternational != null && model.IsInternational.Value) 
            {
            
            }
            else
            {
            
            }
            return NoContent();
        }

        [HttpPost]
        public IActionResult Post_V2(OrderInputModel model,
            [FromServices] InternationalOrderAbstractFactory internationalOrderAbstractFactory,
            [FromServices] NationalOrderAbstractFactory nationalOrderAbstractFactory)
        {
            IOrderAbstractFactory orderAbstractFactory;

            if (model.IsInternational != null && model.IsInternational.Value)
            {
                orderAbstractFactory = internationalOrderAbstractFactory;
            }
            else
            {
                orderAbstractFactory = nationalOrderAbstractFactory;
            }

            var paymentResult = orderAbstractFactory
                .GetPaymentService(model.PaymentInfo.PaymentMethod)
                .Process(model);

            orderAbstractFactory.
                GetDeliveryService()
                .Deliver(model);

            return NoContent();
        }
    }
}
