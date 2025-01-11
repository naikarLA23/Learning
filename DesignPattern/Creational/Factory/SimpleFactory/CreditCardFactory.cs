using FactoryPatten.Products;

namespace FactoryPatten
{
    static internal class CreditCardFactory
    {
        static internal iCreditCard? GetCreditCard(string cardType)
        {
            iCreditCard creditCard = null;  

            switch(cardType)
            {
                case "Platinum":
                    creditCard = new PlatinumCard();
                    break;
                case "Titanium":
                    creditCard = new TitaniumCard();
                    break;
                case "MoneyBack": 
                    creditCard= new MoneyBackCard();
                    break;
                default: 
                    Console.WriteLine("Invalid Card type");
                    break;
            }
            return creditCard;
        }
    }
}
