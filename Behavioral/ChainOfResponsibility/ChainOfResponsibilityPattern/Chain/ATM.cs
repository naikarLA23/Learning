using ChainOfResponsibilityPattern.Handler;

namespace ChainOfResponsibilityPattern.Chain
{
    internal class ATM
    {
        TwoThoundNoteDispenser _TwoThoundNoteDispenser = new();
        FiveHunderNoteDispenser _FiveHunderNoteDispenser = new();
        TwoHunderNoteDispenser _TwoHunderNoteDispenser=new();
        OneHunderNoteDispenser _OneHunderNoteDispenser = new();

        public void CreateChain()
        {
            _TwoThoundNoteDispenser.SetNextHandler(_FiveHunderNoteDispenser);
            _FiveHunderNoteDispenser.SetNextHandler(_TwoHunderNoteDispenser);
            _TwoHunderNoteDispenser.SetNextHandler(_OneHunderNoteDispenser);
        }

        public void Withdraw(int amount)
        {
            Console.WriteLine("Denomination...");
            _TwoThoundNoteDispenser.DispatchNote(amount);
        }
    }
}
