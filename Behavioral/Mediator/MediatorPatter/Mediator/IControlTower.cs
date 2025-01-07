using MediatorPatter.Colleague;

namespace MediatorPatter.Mediator
{
    internal interface IControlTower
    {
        void RegisterRunway(Runway runway);
        bool RequestLandingPermission(Airplane airplane);
        void ReleaseRunway(Runway runway);
    }
}
