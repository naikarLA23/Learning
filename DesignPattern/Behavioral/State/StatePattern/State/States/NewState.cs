using StatePattern.Context;

namespace StatePattern.State.States
{
    internal class NewState : IOrderState
    {
        public void DisplayState()
        {
            Console.WriteLine("Current State is New");
        }

        public void SetNextState(OrderContext orderContext)
        {
            orderContext.SetState(new ProcessedState());
        }

        public void SetPreviousState(OrderContext orderContext)
        {
            Console.WriteLine("Cannot go to previous state is as current state is New");
        }
    }
}
