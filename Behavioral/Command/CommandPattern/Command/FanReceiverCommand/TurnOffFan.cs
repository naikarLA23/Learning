using CommandPattern.Receiver;

namespace CommandPattern.Command.FanReceiverCommand
{
    internal class TurnOffFan(Fan fan) : ICommand
    {
        Fan _Fan = fan;
        public void Execute()
        {
            fan.TurnOff();
        }
    }
}

