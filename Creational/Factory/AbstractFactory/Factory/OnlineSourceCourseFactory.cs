using AbstractFactoryPattern.Products.ProductA;
using AbstractFactoryPattern.Products.ProductB;

namespace AbstractFactoryPattern.Factory
{
    internal class OnlineSourceCourseFactory : ISourceCourseFactory
    {
        public ICourse GetCourse() =>  new BackendCourse();

        public ISource GetSource() => new OnlineSource();
    }
}
