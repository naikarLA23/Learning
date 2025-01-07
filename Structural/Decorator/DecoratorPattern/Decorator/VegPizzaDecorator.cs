using DecoratorPattern.Component.Interface;

namespace DecoratorPattern.Decorator
{
    internal class VegPizzaDecorator : AbstractPizzaDecorator
    {
        public VegPizzaDecorator(IPizza pizza) : base(pizza)
        {
        }

        public override void MakePizza()
        {
            base.MakePizza();
            AddVegetables();
        }

        private void AddVegetables()
        {
            Console.WriteLine("Step 2 : Vegetables added...");
        }
    }
}
