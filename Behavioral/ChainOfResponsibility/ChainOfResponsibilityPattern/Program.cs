using ChainOfResponsibilityPattern.Chain;

namespace ChainOfResponsibilityPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ATM atm = new ATM();
            atm.CreateChain();

            bool canContinue = true;
            while (canContinue)
            {
                Console.WriteLine("Please enter withdraw amount");
                int withdrawAmt = int.Parse(Console.ReadLine().Trim());

                if (withdrawAmt % 100 == 0)
                    atm.Withdraw(withdrawAmt);
                else
                    Console.WriteLine("Please enter withdraw amount in multiple of 100");
                Console.WriteLine("........................................................................");

                Console.WriteLine("Do you want repeat (Y/N)");
                canContinue = Console.ReadLine().Trim().ToUpper() == "Y";
                Console.WriteLine("........................................................................");
            }

            Console.Read();
        }
    }
}
