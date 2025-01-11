using CommandPattern.Receiver;

namespace CommandPattern.Command.FanReceiverCommand
{
    internal class TurnOnFan(Fan fan) : ICommand
    {
        Fan _Fan = fan;
        public void Execute()
        {
            fan.TurnOn();
        }
    }
}
