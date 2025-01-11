using MediatorPatter.Colleague;
using MediatorPatter.Mediator.ConcreteMediator;
using MediatorPatter.Mediator;

namespace MediatorPatter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IControlTower controlTower = new ControlTower();

            // Register two runways
            controlTower.RegisterRunway(new Runway("R1"));
            controlTower.RegisterRunway(new Runway("R2"));

            var airplane1 = new Airplane("FL123", controlTower);
            var airplane2 = new Airplane("FL456", controlTower);
            var airplane3 = new Airplane("FL7866", controlTower);

            airplane1.RequestLanding();
            airplane2.RequestLanding();
            airplane3.RequestLanding();

            Console.ReadKey();
        }
    }
}
