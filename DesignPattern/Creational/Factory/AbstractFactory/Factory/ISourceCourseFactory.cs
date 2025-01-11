using AbstractFactoryPattern.Products.ProductA;
using AbstractFactoryPattern.Products.ProductB;

namespace AbstractFactoryPattern.Factory
{
    internal interface ISourceCourseFactory
    {
        ISource GetSource();
        ICourse GetCourse();
    }
}
