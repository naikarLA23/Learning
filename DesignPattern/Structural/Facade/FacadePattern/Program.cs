using FacadePattern.Facade;

namespace FacadePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OrderProduct orderProduct = new OrderProduct("IFB WashingMachine", 350000, "Phonepe");
            orderProduct.PlaceProductOrder();
            Console.ReadLine();
        }
    }
}
