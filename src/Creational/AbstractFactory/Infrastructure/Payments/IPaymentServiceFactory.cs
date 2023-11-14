using AbstractFactory.Enums;

namespace AbstractFactory.Infrastructure.Payments
{
    public interface IPaymentServiceFactory
    {
        IPaymentService GetService(PaymentMethod paymentMethod);
    }
}
