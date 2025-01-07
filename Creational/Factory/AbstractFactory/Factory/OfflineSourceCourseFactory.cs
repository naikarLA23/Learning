using AbstractFactoryPattern.Products.ProductA;
using AbstractFactoryPattern.Products.ProductB;

namespace AbstractFactoryPattern.Factory
{
    internal class OfflineSourceCourseFactory : ISourceCourseFactory
    {
        public ICourse GetCourse() => new FrontEndCourse();

        public ISource GetSource() => new OfflineSource();
    }
}
