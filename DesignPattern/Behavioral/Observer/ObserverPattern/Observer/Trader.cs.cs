namespace ObserverPattern.Observer
{
    internal class Trader(string username) : ITrader
    {
        public string UserName { get; set; } = username;

        public void ShowNotification(decimal newValue)
        {
            Console.WriteLine($"Hi {UserName}, Share price changed to {newValue}");
        }
    }
}