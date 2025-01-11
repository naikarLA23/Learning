namespace StratergyMethodPattern.Stratergy.ConcreteStratergy
{
    internal class Voucher : IPaymentStratergy
    {
        public void MakePayment(int amount)
        {
            Console.WriteLine($"{this.GetType().Name} payment of Rs {amount} done. ");
        }
    }
}
