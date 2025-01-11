using ObserverPattern.Observer;
using ObserverPattern.Publisher;

namespace ObserverPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Trader trader1 = new Trader("Rajat");
            Trader trader2 = new Trader("Vikram");
            Trader trader3 = new Trader("Manju");

            Share share1 = new Share("SBI Bank", 810);
            Share share2 = new Share("IOCL", 530);
            Share share3 = new Share("BEL", 620);

            share1.RegisterTrader(trader1);
            share1.RegisterTrader(trader2);

            share2.RegisterTrader(trader2);
            share2.RegisterTrader(trader3);

            share3.RegisterTrader(trader1);
            share3.RegisterTrader(trader3);

            Console.WriteLine("........................................................................");
            share1.UpdateValue(840);
            Console.WriteLine("........................................................................");

            share2.UpdateValue(560);
            Console.WriteLine("........................................................................");

            share3.UpdateValue(580);
            Console.WriteLine("........................................................................");

            share1.UnregisterTrader(trader2);
            share3.UnregisterTrader(trader2);
            share3.UnregisterTrader(trader3);

            Console.WriteLine("........................................................................");
            share1.UpdateValue(820);
            Console.WriteLine("........................................................................");

            share3.UpdateValue(500);
            Console.WriteLine("........................................................................");


            Console.WriteLine("........................................................................");
            Console.Read();
        }
    }
}
