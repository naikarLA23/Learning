using StatePattern.Context;

namespace StatePattern.State.States
{
    internal class ProcessedState : IOrderState
    {
        public void DisplayState()
        {
            Console.WriteLine("Current State is Processed");
        }

        public void SetNextState(OrderContext orderContext)
        {
            orderContext.SetState(new ShippedState());
        }

        public void SetPreviousState(OrderContext orderContext)
        {
            orderContext.SetState(new NewState());
        }
    }
}
