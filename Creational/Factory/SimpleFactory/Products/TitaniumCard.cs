namespace FactoryPatten.Products
{
    internal class TitaniumCard : iCreditCard
    {
        public string GetAnnualCharge() => $"Annual charge = Rs 800";

        public string GetCardType() => $"CreditCard Type = Titanium";

        public string GetCreditCardLimit() => $"Credit Card Limit = Rs 2,00,000";
    }
}
