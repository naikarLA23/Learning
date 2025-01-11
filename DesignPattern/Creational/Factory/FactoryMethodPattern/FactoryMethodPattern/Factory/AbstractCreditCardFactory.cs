using FactoryMethodPattern.Product;

namespace FactoryMethodPattern.Factory
{
    internal abstract class AbstractCreditCardFactory
    {
        protected abstract ICreditCard GetCreditCard();

        public ICreditCard CreateProduct()
        {
            //Call the MakeProduct which will create and return the appropriate object 
            ICreditCard creditCard = this.GetCreditCard();
            //Return the Object to the Client
            return creditCard;
        }
    }
}
