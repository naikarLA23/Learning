using TemplatePattern.Template;
using TemplatePattern.Template.ConcreteTemplates;

namespace TemplatePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HouseTemplate houseTemplate = new CementHouse();
            houseTemplate.BuildHouse();
            Console.WriteLine("---------------------------------------------------");

            houseTemplate = new WoodenHouse();
            houseTemplate.BuildHouse();
            Console.WriteLine("---------------------------------------------------");

            Console.ReadLine();
        }
    }
}
