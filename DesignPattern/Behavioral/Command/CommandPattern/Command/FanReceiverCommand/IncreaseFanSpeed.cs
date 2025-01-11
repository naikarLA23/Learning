using CommandPattern.Receiver;

namespace CommandPattern.Command
{
    internal class IncreaseFanSpeed(Fan fan) : ICommand
    {
        Fan _Fan = fan;
        public void Execute()
        {
            fan.DecreaseSpeed();
        }
    }
}
