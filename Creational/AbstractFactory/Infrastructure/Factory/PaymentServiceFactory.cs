﻿using AbstractFactory.Enums;
using AbstractFactory.Infrastructure.Payments;

namespace AbstractFactory.Infrastructure.Factory
{
    public class PaymentServiceFactory : IPaymentServiceFactory
    {
        private readonly CreditCardService _creditCardService;
        private readonly PaymentSlipService _paymentSlipService;

        public PaymentServiceFactory(CreditCardService creditCardService, PaymentSlipService paymentSlipService)
        {
            _creditCardService = creditCardService;
            _paymentSlipService = paymentSlipService;
        }
        public IPaymentService GetService(PaymentMethod paymentMethod)
        {
            IPaymentService paymentService;
            switch (paymentMethod)
            {
                case PaymentMethod.CreditCard:
                    paymentService = _creditCardService;
                    break;
                case PaymentMethod.PaymentSlip:
                    paymentService = _paymentSlipService;
                    break;
                default:
                    throw new InvalidOperationException("Invalid Operation");
            }

            return paymentService;
        }
    }
}
