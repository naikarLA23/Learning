using StratergyMethodPattern.Context;
using StratergyMethodPattern.Stratergy.ConcreteStratergy;

namespace StratergyMethodPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PurchaseContext purchaseContext = new();

            purchaseContext.SetStratergy(new Cash());
            purchaseContext.PayBill(2000);
            Console.WriteLine("---------------------------------------------------------------------------------------------------");

            purchaseContext.SetStratergy(new CreditCard());
            purchaseContext.PayBill(5000);
            Console.WriteLine("---------------------------------------------------------------------------------------------------");

            purchaseContext.SetStratergy(new DebitCard());
            purchaseContext.PayBill(9000);
            Console.WriteLine("---------------------------------------------------------------------------------------------------");

            purchaseContext.SetStratergy(new Voucher());
            purchaseContext.PayBill(1000);
            Console.WriteLine("---------------------------------------------------------------------------------------------------");

            Console.ReadLine();
        }
    }
}
