using Builder.Infrastructure.Factory;
using Builder.Models;
using Microsoft.AspNetCore.Mvc;

namespace Builder.Controllers
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
        public IActionResult Post(OrderInputModel model)
        {
            var paymentService = _paymentServiceFactory.GetService(model.PaymentInfo.PaymentMethod);
            paymentService.Process(model);
            return NoContent();
        }
    }
}
