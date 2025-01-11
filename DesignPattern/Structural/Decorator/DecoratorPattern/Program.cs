using DecoratorPattern.Component.Concrete;
using DecoratorPattern.Decorator;

namespace DecoratorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("............................Plain Pizza............................................");
            PlainPizza plainPizza = new();
            plainPizza.MakePizza();

            Console.WriteLine("\n............................Veg Pizza............................................");
            VegPizzaDecorator vegPizza = new(plainPizza);
            vegPizza.MakePizza();
            
            
            Console.WriteLine("\n........................Chicken Pizza................................................");
            ChickenPizzaDecorator chickenPizza = new(plainPizza);
            chickenPizza.MakePizza();

            Console.WriteLine("........................................................................");
            Console.Read();
        }
    }
}
