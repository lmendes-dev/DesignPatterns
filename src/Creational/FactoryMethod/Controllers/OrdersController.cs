using FactoryMethod.Core;
using FactoryMethod.Enums;
using FactoryMethod.Infrastructure.Payments;
using Microsoft.AspNetCore.Mvc;

namespace FactoryMethod.Controllers
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
            switch (model.PaymentInfo)
            {
                case PaymentMethod.CreditCard:
                    //Código para processar pagamento de cartão de crédito
                    break;
                case PaymentMethod.PaymentSlip:
                    //Código de gerar boleto e notificação
                    break;
                default:
                    return BadRequest("Meio de pagamento não identificado!");
            }

            return NoContent();
        }


        [HttpPost]
        public IActionResult Post_FactoryMethod(OrderInputModel model)
        {
            var paymentService = _paymentServiceFactory.GetService(model.PaymentInfo);
            paymentService.Process(model);

            return NoContent();
        }

    }
}
