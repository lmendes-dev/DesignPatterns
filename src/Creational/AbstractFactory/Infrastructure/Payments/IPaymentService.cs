using AbstractFactory.Core;

namespace AbstractFactory.Infrastructure.Payments
{
    public interface IPaymentService
    {
        object Process(OrderInputModel model);
    }
}
