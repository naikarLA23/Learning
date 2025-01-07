using StatePattern.Context;

namespace StatePattern.State.States
{
    internal class ShippedState : IOrderState
    {
        public void DisplayState()
        {
            Console.WriteLine("Current State is Shipped");
        }

        public void SetNextState(OrderContext orderContext)
        {
            orderContext.SetState(new DeliveredState());
        }

        public void SetPreviousState(OrderContext orderContext)
        {
            orderContext.SetState(new ProcessedState());
        }
    }
}
