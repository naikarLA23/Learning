namespace FactoryMethodPattern.Product
{
    internal class MoneyBackCard : ICreditCard
    {
        public string GetAnnualCharge() => $"Annual charge = Rs 1,200";

        public string GetCardType() => $"CreditCard Type = MoneyBack";

        public string GetCreditCardLimit() => $"Credit Card Limit = Rs 3,50,000";
    }
}
