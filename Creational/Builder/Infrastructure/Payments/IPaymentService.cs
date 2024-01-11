using Builder.Models;

namespace Builder.Infrastructure.Payments
{
    public interface IPaymentService
    {
        object Process(OrderInputModel model);
    }
}
