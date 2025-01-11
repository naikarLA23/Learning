using ObserverPattern.Observer;
using System.Diagnostics;

namespace ObserverPattern.Publisher
{
    internal class Share(string stockName, decimal newValue) : IShare
    {
        private string ShareName = stockName;
        private decimal Value = newValue;
        List<ITrader> Traders = new();

        public void NotifyTrader()
        {
            foreach (var trader in Traders)
            {
                trader.ShowNotification(Value);
            }
        }

        public void RegisterTrader(Trader trader)
        {
            Traders.Add(trader);
                Console.WriteLine($"{ShareName} --> Subscribered trader : {trader.UserName}");

        }

        public void UnregisterTrader(Trader trader)
        {
            if (Traders.Remove(trader))
                Console.WriteLine($"{ShareName} --> Unsubscribered trader : {trader.UserName}");
            else
                Console.WriteLine($"{ShareName} --> Failed to unsubscribe trader : {trader.UserName}.  Not found in subscribed list");
        }

        public void UpdateValue(decimal value)
        {
            Console.WriteLine($"{ShareName} --> Value changed...");
            Value = value;
            NotifyTrader();
        }
    }
}
