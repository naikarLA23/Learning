using DecoratorPattern.Component.Concrete;
using DecoratorPattern.Component.Interface;

namespace DecoratorPattern.Decorator
{
    internal class AbstractPizzaDecorator : PlainPizza
    {
        protected IPizza _Pizza;

        public AbstractPizzaDecorator(IPizza pizza)
        {
            _Pizza = pizza;
        }

        public virtual void MakePizza()
        {
            _Pizza.MakePizza();
        }
    }
}
