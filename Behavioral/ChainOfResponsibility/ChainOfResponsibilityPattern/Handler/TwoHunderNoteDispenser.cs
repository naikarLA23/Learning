namespace ChainOfResponsibilityPattern.Handler
{
    internal class TwoHunderNoteDispenser : AbstractNoteDispenser
    {
        private readonly int _denominationAmount = 200;
        internal override void DispatchNote(long requestedAmount)
        {
            if (requestedAmount >= _denominationAmount)
            {
                var dispatchCount = requestedAmount / _denominationAmount;
                Console.WriteLine($"Dispatching Rs {_denominationAmount} * {dispatchCount}");

                var remainingAmt = requestedAmount % _denominationAmount;
                if (remainingAmt > 0)
                {
                    if (NextHandler != null)
                        NextHandler.DispatchNote(remainingAmt);
                    else
                        Console.WriteLine($"Next handler not set");
                }
                else
                {
                    Console.WriteLine($"Note dispatch completed...");
                }
            }
        }
    }
}