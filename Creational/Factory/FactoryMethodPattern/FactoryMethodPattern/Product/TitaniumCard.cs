namespace FactoryMethodPattern.Product
{
    internal class TitaniumCard : ICreditCard
    {
        public string GetAnnualCharge() => $"Annual charge = Rs 800";

        public string GetCardType() => $"CreditCard Type = Titanium";

        public string GetCreditCardLimit() => $"Credit Card Limit = Rs 2,00,000";
    }
}
