using Builder.Enums;
using Builder.Infrastructure.Payments;

namespace Builder.Infrastructure.Factory
{
    public interface IPaymentServiceFactory
    {
        IPaymentService GetService(PaymentMethod paymentMethod);
    }
}
