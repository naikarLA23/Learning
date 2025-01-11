namespace FactoryMethodPattern.Product
{
    internal interface ICreditCard
    {
        string GetCardType();
        string GetCreditCardLimit();
        string GetAnnualCharge();
    }
}
