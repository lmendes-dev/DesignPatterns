using AbstractFactory.Enums;
using AbstractFactory.Infrastructure.Deliveries;
using AbstractFactory.Infrastructure.Factory;
using AbstractFactory.Infrastructure.Payments;

namespace AbstractFactory.Infrastructure
{
    public class InternationalOrderAbstractFactory : IOrderAbstractFactory
    {
        private readonly InternationalDeliveryService _internationalDeliveryService;
        private readonly CreditCardService _creditCardService;

        public InternationalOrderAbstractFactory(InternationalDeliveryService internationalDeliveryService,
            CreditCardService creditCardService)
        {
            _internationalDeliveryService = internationalDeliveryService;
            _creditCardService = creditCardService;
        }
        public IDeliveryService GetDeliveryService()
        {
            return _internationalDeliveryService;
        }

        public IPaymentService GetPaymentService(PaymentMethod paymentMethod)
        {
            return _creditCardService;
        }
    }
}
