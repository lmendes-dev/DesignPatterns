using AbstractFactory.Enums;

namespace AbstractFactory.Core
{
    public class OrderInputModel
    {
        public PaymentMethod PaymentInfo { get; set; }
        public bool IsInternational { get;  set; }
    }
}
