using Prototype.Models;
using Microsoft.AspNetCore.Mvc;

namespace Builder.Controllers
{
    [ApiController]
    [Route("api/orders")]
    public class OrdersController : ControllerBase
    {
        private readonly ILogger<OrdersController> _logger;

        public OrdersController(ILogger<OrdersController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public IActionResult Post_V1(OrderInputModel model)
        {
            var customerCopy = new CustomerInputModel
            {
                Id = model.Customer.Id,
                FullName = model.Customer.FullName,
                Email = model.Customer.Email,
                Document = model.Customer.Document
            };

            return Ok(customerCopy);
        }

        [HttpPost]
        public IActionResult Post_V2(OrderInputModel model)
        {
            var customerCopy = model.Customer.Clone();

            return Ok(customerCopy);
        }
    }
}
