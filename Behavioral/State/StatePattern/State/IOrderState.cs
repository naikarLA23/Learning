using StatePattern.Context;

namespace StatePattern.State
{
    internal interface IOrderState
    {
        void SetNextState(OrderContext orderContext);
        void SetPreviousState(OrderContext orderContext);
        void DisplayState();
    }
}
