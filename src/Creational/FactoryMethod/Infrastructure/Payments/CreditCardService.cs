using FactoryMethod.Core;

namespace FactoryMethod.Infrastructure.Payments
{
    public class CreditCardService : IPaymentService
    {
        public object Process(OrderInputModel model)
        {
            return "Pagamento via Cartão de Crédito";
        }
    }
}
