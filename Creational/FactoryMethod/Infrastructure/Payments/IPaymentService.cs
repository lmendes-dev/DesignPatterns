﻿using FactoryMethod.Models;

namespace FactoryMethod.Infrastructure.Payments
{
    public interface IPaymentService
    {
        object Process(OrderInputModel model);
    }
}
