using FlyweightPattern.FlyweightFactory;
using FlyweightPattern.InterfaceFlyweight;

namespace FlyweightPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShapeFactory shapeFactory = new ShapeFactory();
            string color = "Orange";
            string shapeType = "circle";
            int count = 3;
            CreateObject(shapeFactory, color, count);
            Console.WriteLine("----------------------------------------------------");

             color = "Green";
             shapeType = "circle";
             count = 4;
            CreateObject(shapeFactory, color, count);
            Console.WriteLine("----------------------------------------------------");

            color = "Black";
            shapeType = "circle";
            count = 2;
            CreateObject(shapeFactory, color, count);
            Console.WriteLine("----------------------------------------------------");

            color = "Yellow";
            shapeType = "circle";
            count = 4;
            CreateObject(shapeFactory, color, count);
            Console.WriteLine("----------------------------------------------------");

            Console.ReadLine();
        }

        private static void CreateObject(ShapeFactory shapeFactory, string color, int count)
        {
            Console.WriteLine($"Creating {count} {color} color Circle");
            IShape shape = null;
            for (int i = 0; i < count; i++)
            {
                shape = shapeFactory.GetShape("shapeType", color);
                shape.SetColor(color);
                shape.Draw();
            }
        }
    }
}
