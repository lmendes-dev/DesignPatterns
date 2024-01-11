using AbstractFactory.Models;

namespace AbstractFactory.Infrastructure.Payments
{
    public class PaymentSlipService : IPaymentService
    {
        public object Process(OrderInputModel model)
        {
            return "Invoice details";
        }
    }
}
