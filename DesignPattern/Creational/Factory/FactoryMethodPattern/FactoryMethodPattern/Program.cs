using FactoryMethodPattern.Factory;
using FactoryMethodPattern.Product;

namespace FactoryMethodPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AbstractCreditCardFactory creditCardFactory = new PlatinumCreditCardFactory();
            PrintCardDetails( creditCardFactory.CreateProduct());

            creditCardFactory = new TitaniumCreditCardFactory();
            PrintCardDetails(creditCardFactory.CreateProduct());

            creditCardFactory = new MoneyBackCreditCardFactory();
            PrintCardDetails(creditCardFactory.CreateProduct());
            
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Press Any Key to exit...............");
            Console.ReadKey();
        }

        private static void PrintCardDetails(ICreditCard creditCard)
        {
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine(".................................................................");
            if (creditCard != null)
            {
                Console.WriteLine(creditCard.GetCardType());
                Console.WriteLine(creditCard.GetCreditCardLimit());
                Console.WriteLine(creditCard.GetAnnualCharge());
            }
            else
                Console.WriteLine("Invalid Card");

        }
    }
}
