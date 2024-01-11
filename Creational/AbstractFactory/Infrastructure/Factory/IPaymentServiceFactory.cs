using AbstractFactory.Enums;
using AbstractFactory.Infrastructure.Payments;

namespace AbstractFactory.Infrastructure.Factory
{
    public interface IPaymentServiceFactory
    {
        IPaymentService GetService(PaymentMethod paymentMethod);
    }
}
