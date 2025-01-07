using FactoryMethodPattern.Product;

namespace FactoryMethodPattern.Factory
{
    internal class TitaniumCreditCardFactory : AbstractCreditCardFactory
    {
        protected override ICreditCard GetCreditCard() => new TitaniumCard();
    }
}
