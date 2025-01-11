using CommandPattern.Receiver;

namespace CommandPattern.Command
{
    internal class IncreaseTvVolume(Television tv) : ICommand
    {
        Television _Television = tv;
        public void Execute()
        {
            tv.VolumeUp();
        }
    }
}


