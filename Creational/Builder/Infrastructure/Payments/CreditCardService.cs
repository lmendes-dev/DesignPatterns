using Builder.Models;

namespace Builder.Infrastructure.Payments
{
    public class CreditCardService : IPaymentService
    {
        public object Process(OrderInputModel model)
        {
            return "Credit Card approved";
        }
    }
}
