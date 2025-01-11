using MediatorPatter.Colleague;

namespace MediatorPatter.Mediator.ConcreteMediator
{
    internal class ControlTower : IControlTower
    {
        private List<Runway> _availableRunways = new();

        public void RegisterRunway(Runway runway)
        {
            _availableRunways.Add(runway);
        }

        public void ReleaseRunway(Runway runway)
        {
            _availableRunways.Remove(runway);
        }

        public bool RequestLandingPermission(Airplane airplane)
        {
            Console.WriteLine($"----------------------------------------- ");

            var result = false;

            if(_availableRunways.Any())
            {

                var runway = _availableRunways.First();
                _availableRunways.Remove(runway);
                airplane.AssignRunway(runway);
                result = true;
            }
            else
            {
                Console.WriteLine($"No Runway avaliable for landing. Please wait... ");
            }
            return result;
        }
    }
}
