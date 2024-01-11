using FactoryMethod.Enums;
using FactoryMethod.Infrastructure.Payments;

namespace FactoryMethod.Infrastructure.Factory
{
    public interface IPaymentServiceFactory
    {
        IPaymentService GetService(PaymentMethod paymentMethod);
    }
}
