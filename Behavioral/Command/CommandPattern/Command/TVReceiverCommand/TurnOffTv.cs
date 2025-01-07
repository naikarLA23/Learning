using CommandPattern.Receiver;

namespace CommandPattern.Command.TVReceiverCommand
{
    internal class TurnOffTv(Television tv) : ICommand
    {
        Television _Television = tv;
        public void Execute()
        {
            tv.TurnOff();
        }
    }
}
