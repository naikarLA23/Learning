namespace StratergyMethodPattern.Stratergy.ConcreteStratergy
{
    internal class DebitCard : IPaymentStratergy
    {
        public void MakePayment(int amount)
        {
            Console.WriteLine($"{this.GetType().Name} payment of Rs {amount} done. ");
        }
    }
}
