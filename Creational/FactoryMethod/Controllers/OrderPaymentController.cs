using FactoryMethod.Enums;
using FactoryMethod.Infrastructure.Factory;
using FactoryMethod.Models;
using Microsoft.AspNetCore.Mvc;

namespace FactoryMethod.Controllers
{
    [ApiController]
    [Route("api/orderPayment")]
    public class OrderPaymentController : ControllerBase
    {
        private readonly ILogger<OrderPaymentController> _logger;
        private readonly IPaymentServiceFactory _paymentServiceFactory;

        public OrderPaymentController(ILogger<OrderPaymentController> logger, IPaymentServiceFactory paymentServiceFactory)
        {
            _logger = logger;
            _paymentServiceFactory = paymentServiceFactory;
        }

        [HttpPost]
        public IActionResult Post_V1(OrderInputModel model)
        {
            switch (model.PaymentInfo.PaymentMethod)
            {
                case PaymentMethod.CreditCard:
                    //Process credit card payment
                    break;
                case PaymentMethod.PaymentSlip:
                    //Process generate invoice
                    break;
                default:
                    return BadRequest("Unidentified payment method");
            }
            return NoContent();
        }

        [HttpPost]
        public IActionResult Post_V2(OrderInputModel model)
        {
            var paymentService = _paymentServiceFactory.GetService(model.PaymentInfo.PaymentMethod);
            paymentService.Process(model);
            return NoContent();
        }
    }
}
