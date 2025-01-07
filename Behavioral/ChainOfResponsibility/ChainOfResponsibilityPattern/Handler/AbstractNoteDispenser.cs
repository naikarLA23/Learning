namespace ChainOfResponsibilityPattern.Handler
{
    internal abstract class AbstractNoteDispenser
    {
        internal AbstractNoteDispenser NextHandler;
        internal abstract void DispatchNote(long requestedAmount);

        internal void SetNextHandler(AbstractNoteDispenser handler)
        {
            NextHandler = handler;
        }
    }
}
