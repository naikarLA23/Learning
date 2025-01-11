using DecoratorPattern.Component.Interface;

namespace DecoratorPattern.Component.Concrete
{
    internal class PlainPizza : IPizza
    {
        public void MakePizza()
        {
            Console.WriteLine("Step 1 : Preparing plain pizza...");
        }
    }
}
