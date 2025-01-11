using CommandPattern.Command;
using CommandPattern.Command.FanReceiverCommand;
using CommandPattern.Command.TVReceiverCommand;
using CommandPattern.Invoker;
using CommandPattern.Receiver;

namespace TemplatePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RemoteControl remote = new RemoteControl();

            Television tv = new Television();
            ICommand turnOnTv = new TurnOnTV(tv);
            remote.SetCommand(turnOnTv);
            remote.PressButton();
            Console.WriteLine("---------------------------------------------------");

            ICommand turnOffTv = new TurnOffTv(tv);
            remote.SetCommand(turnOffTv);
            remote.PressButton();
            Console.WriteLine("---------------------------------------------------");

            ICommand volumeUpTv = new IncreaseTvVolume(tv);
            remote.SetCommand(volumeUpTv);
            remote.PressButton();
            Console.WriteLine("---------------------------------------------------");

            ICommand volumeDownTv = new DecreaseTvVolume(tv);
            remote.SetCommand(volumeDownTv);
            remote.PressButton();
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("---------------------------------------------------");

            Fan fan = new Fan();
            ICommand turnOnFan = new TurnOnFan(fan);
            remote.SetCommand(turnOnFan);
            remote.PressButton();
            Console.WriteLine("---------------------------------------------------");

            ICommand turnOffFan = new TurnOffFan(fan);
            remote.SetCommand(turnOffFan);
            remote.PressButton();
            Console.WriteLine("---------------------------------------------------");

            ICommand speedUpFan = new IncreaseFanSpeed(fan);
            remote.SetCommand(speedUpFan);
            remote.PressButton();
            Console.WriteLine("---------------------------------------------------");
            ICommand speedDownFan = new DecreaseFanSpeed(fan);
            remote.SetCommand(speedDownFan);
            remote.PressButton();

            Console.WriteLine("---------------------------------------------------");
            Console.ReadLine();
        }
    }
}
