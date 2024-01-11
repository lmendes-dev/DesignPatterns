using Builder.Models;

namespace Builder.Infrastructure.Payments
{
    public class PaymentSlipService : IPaymentService
    {
        public object Process(OrderInputModel model)
        {
            //Old
            var paymentSlip = new PaymentSlipModel(
                "12333.23213432-1.212132432", "12324111", DateTime.Now.AddDays(3), DateTime.Now, 1234.0m,
                new Payer("Pagador", "123.435.533-12", "Rua do Pagador"),
                new Receiver("Recebedor", "123.542.642.-12", "Rua do Recebedor")
                );

            //New
            var builder = new PaymentSlipBuilder();
            var paymentSlipByBuilder = builder
                .WihReceiver(new Receiver("Recebedor", "123.542.642.-12", "Rua do Recebedor"))
                .WihPayer(new Payer("Pagador", "123.435.533-12", "Rua do Pagador"))
                .WithPaymentDocument("12333.23213432-1.212132432", "12324111", 1234.0m)
                .WithDates(DateTime.Now, DateTime.Now.AddDays(3))
                .Build();

            return "Dados do Boleto";
        }
    }
}
