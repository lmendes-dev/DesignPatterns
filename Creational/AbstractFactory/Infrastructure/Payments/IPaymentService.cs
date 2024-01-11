using AbstractFactory.Models;

namespace AbstractFactory.Infrastructure.Payments
{
    public interface IPaymentService
    {
        object Process(OrderInputModel model);
    }
}
