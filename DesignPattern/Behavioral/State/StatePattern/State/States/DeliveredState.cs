using StatePattern.Context;

namespace StatePattern.State.States
{
    internal class DeliveredState : IOrderState
    {
        public void DisplayState()
        {
            Console.WriteLine("Current State is Delivered");
        }

        public void SetNextState(OrderContext orderContext)
        {
            Console.WriteLine("No next state defined. Current State is Delivered");
        }

        public void SetPreviousState(OrderContext orderContext)
        {
            orderContext.SetState(new ShippedState());
        }
    }
}
