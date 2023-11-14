using AbstractFactory.Core;

namespace AbstractFactory.Infrastructure.Payments
{
    public class CreditCardService : IPaymentService
    {
        public object Process(OrderInputModel model)
        {
            throw new NotImplementedException();
        }
    }
}
