using FacadePattern.Subsystem;

namespace FacadePattern.Facade
{
    internal class OrderProduct(string productName, int amount, string gateway)
    {
        protected string ProductName { get; set; } = productName;
        protected int Amount { get; set; } = amount;
        protected string PaymentGateway { get; set; } = gateway;

        internal void PlaceProductOrder()
        {
            Product product = new Product(ProductName);
            product.AddProduct();

            Payment payment = new Payment(PaymentGateway, Amount);
            payment.MakePayment();

            Invoice invoice = new Invoice();
            invoice.CreateInvoice();
        }
    }
}
