using ObserverPattern.Observer;

namespace ObserverPattern.Publisher
{
    internal interface IShare
    {
        void RegisterTrader(Trader trader);
        void UnregisterTrader(Trader trader);
        void NotifyTrader();
    }
}
