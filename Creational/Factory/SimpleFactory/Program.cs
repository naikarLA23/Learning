using FactoryPatten;
using FactoryPatten.Products;

namespace Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            iCreditCard creditCard = CreditCardFactory.GetCreditCard("Platinum");
            PrintCardDetails(creditCard);

            creditCard = CreditCardFactory.GetCreditCard("Titanium");
            PrintCardDetails(creditCard);

            creditCard = CreditCardFactory.GetCreditCard("MoneyBack");
            PrintCardDetails(creditCard);

            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Press Any Key to exit...............");
            Console.ReadKey();
        }

        private static void PrintCardDetails(iCreditCard creditCard)
        {
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine(".................................................................");
            if (creditCard!=null)
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
