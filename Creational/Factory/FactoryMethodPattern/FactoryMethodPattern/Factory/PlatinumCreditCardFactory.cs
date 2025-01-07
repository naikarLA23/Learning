using FactoryMethodPattern.Product;

namespace FactoryMethodPattern.Factory
{
    internal class PlatinumCreditCardFactory : AbstractCreditCardFactory
    {
        protected override ICreditCard GetCreditCard() => new PlatinumCard();
    }
}
