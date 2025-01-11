using StatePattern.Context;

namespace StatePattern.State.States
{
    internal class CancelledState : IOrderState
    {
        public void DisplayState()
        {
            Console.WriteLine("Current State is Cancelled");
        }

        public void SetNextState(OrderContext orderContext)
        {
            Console.WriteLine("No next state defined. Current State is Cancelled");
        }

        public void SetPreviousState(OrderContext orderContext)
        {
            Console.WriteLine("No previous state defined. Current State is Cancelled");
        }
    }
}
