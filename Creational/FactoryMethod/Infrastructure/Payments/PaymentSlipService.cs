using FactoryMethod.Models;

namespace FactoryMethod.Infrastructure.Payments
{
    public class PaymentSlipService : IPaymentService
    {
        public object Process(OrderInputModel model)
        {
            return "Invoice details";
        }
    }
}
