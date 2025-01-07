using FlyweightPattern.InterfaceFlyweight;

namespace FlyweightPattern.ConcreteFlyweight
{
    internal class Circle() : IShape
    {
        //Intrinsic Properties i.e Static
        private readonly int XCo_Ordinate = 10;
        private readonly int YCo_Ordinate = 20;
        private readonly int Radius = 100;

        //Extrinsic Properties i.e Dynamic
        public string Color { get; set; }

        public void Draw()
        {
            Console.WriteLine("Shape details...");
           Console.WriteLine($"X Co-Ordinate : {XCo_Ordinate}, Y Co-Ordinate : {YCo_Ordinate}, Radius : {Radius}, Color :{Color}");
        }

        public void SetColor(string color)
        {
            Color = color;
        }
    }
}
