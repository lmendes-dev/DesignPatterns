using Singleton.Models;
using Microsoft.AspNetCore.Mvc;

namespace Singleton.Controllers
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
        public IActionResult Post()
        {
            return Ok(BusinessHours.GetInstance());
        }
    }
}
