namespace FluentInterfaceDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var order = new ShoppingCartBuilder()
           .AddProduct("Laptop", 1000m)
           .AddProduct("Mouse", 50m)
           .RemoveProduct("Mouse")
           .AddProduct("Keyboard", 70m)
           .Checkout();
            Console.WriteLine($"Total Price: {order.TotalPrice}");
            // Outputs: Total Price: 1070
            Console.ReadKey();
        }
    }
}
