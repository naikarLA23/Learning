using StatePattern.Context;
using StatePattern.State.States;

namespace StatePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OrderContext order = new OrderContext(new NewState());
            order.DisplayState();  // Output: Order is in NEW state.
            order.PrevState();

            order.NextState();
            order.DisplayState();  // Output: Order is PROCESSED.

            order.NextState();
            order.DisplayState();  // Output: Order is SHIPPED.

            //order.PrevState();
            //order.DisplayState();  // Output: Order is PROCESSED.

            order.NextState();
            order.DisplayState(); // Delivered State

            order.SetState(new CancelledState());// Output: Order is CANCELED.
            order.DisplayState();
            order.NextState();
            order.PrevState();


            Console.ReadKey();
        }
    }
}
