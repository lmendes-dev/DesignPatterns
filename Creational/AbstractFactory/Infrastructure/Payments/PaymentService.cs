using AbstractFactory.Models;

namespace AbstractFactory.Infrastructure.Payments
{
    public class PaymentService : IPaymentService
    {
        public object Process(OrderInputModel model)
        {
            throw new NotImplementedException();
        }
    }
}
