using FactoryMethod.Core;

namespace FactoryMethod.Infrastructure.Payments
{
    public class PaymentSlipService : IPaymentService
    {
        public object Process(OrderInputModel model)
        {
            return "Pagamento via boleto";
        }
    }
}
