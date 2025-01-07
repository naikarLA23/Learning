using FactoryMethodPattern.Product;

namespace FactoryMethodPattern.Factory
{
    internal class MoneyBackCreditCardFactory : AbstractCreditCardFactory
    {
        protected override ICreditCard GetCreditCard() => new PlatinumCard();
    }
}
