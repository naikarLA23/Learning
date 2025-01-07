using FlyweightPattern.ConcreteFlyweight;
using FlyweightPattern.InterfaceFlyweight;

namespace FlyweightPattern.FlyweightFactory
{
    internal class ShapeFactory
    {
        Dictionary<string, IShape> ShapeObjects = new Dictionary<string, IShape>();
        public IShape GetShape(string shapeType, string color)
        {
            IShape shape;
            if (ShapeObjects.ContainsKey(shapeType))
            {
                shape = ShapeObjects[shapeType];
            }
            else
            {
                shape = new Circle();
                ShapeObjects.Add(shapeType, shape);
            }
            return shape;
        }
    }
}
