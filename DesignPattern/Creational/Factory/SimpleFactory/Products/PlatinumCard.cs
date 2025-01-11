namespace FactoryPatten.Products
{
    internal class PlatinumCard : iCreditCard
    {
        public string GetAnnualCharge() => $"Annual charge = Rs 1,000";

        public string GetCardType() => $"CreditCard Type = Platinum";

        public string GetCreditCardLimit() =>$"Credit Card Limit = Rs 4,00,000";
    }
}
