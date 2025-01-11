using CommandPattern.Receiver;

namespace CommandPattern.Command
{
    internal class DecreaseTvVolume(Television tv) : ICommand
    {
        Television _Television = tv;
        public void Execute()
        {
            tv.VolumeDown();
        }
    }
}

