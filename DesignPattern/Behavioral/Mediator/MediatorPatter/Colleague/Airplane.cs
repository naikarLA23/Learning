using MediatorPatter.Mediator;

namespace MediatorPatter.Colleague
{
    internal class Airplane(string flightNbr, IControlTower ctrlTower)
    {
        public string FlightNumber { get; set; } = flightNbr;

        private readonly IControlTower _controlTower = ctrlTower;

        public void RequestLanding()
        {
            if (_controlTower.RequestLandingPermission(this))
            {
                Console.WriteLine($"Airplane {FlightNumber} is landing.");
            }
            else
            {
                Console.WriteLine($"Airplane {FlightNumber} is waiting for an available runway.");
            }
        }

        public void AssignRunway(Runway runway)
        {
            Console.WriteLine($"Airplane {FlightNumber} assigned to runway {runway.RunwayNumber}.");
        }
    }
}
