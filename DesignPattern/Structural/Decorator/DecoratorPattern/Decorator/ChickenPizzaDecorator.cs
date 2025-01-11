using DecoratorPattern.Component.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Decorator
{
    internal class ChickenPizzaDecorator : AbstractPizzaDecorator
    {
        public ChickenPizzaDecorator(IPizza pizza) : base(pizza)
        {
        }

        public override void MakePizza()
        {
            base.MakePizza();
            AddChicken();
        }

        private void AddChicken()
        {
            Console.WriteLine("Step 2 : Chicken added....");
        }
    }
}
