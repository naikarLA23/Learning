using CommandPattern.Receiver;

namespace CommandPattern.Command.TVReceiverCommand
{
    internal class TurnOnTV(Television tv) : ICommand
    {
        Television _Television = tv;
        public void Execute()
        {
            tv.TurnOn();
        }
    }
}
