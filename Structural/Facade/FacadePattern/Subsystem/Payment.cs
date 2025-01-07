namespace FacadePattern.Subsystem
{
    internal class Payment(string gateway, int amount)
    {
        internal int Amount { get; set; } = amount;
        internal string Gateway { get; set; } = gateway;

        internal void MakePayment()
        {
            Console.WriteLine($"Making payment of Rs {Amount} from Gateway: {Gateway}");
        }
    }
}
