using TemplatePattern.Template.ConcreteTemplates;

namespace TemplatePattern.Template
{
    internal class WoodenHouse : HouseTemplate
    {
        protected override void AddWindowsAndDoor()
        {
            Console.WriteLine("Adding doors and Windows to wooden house");
        }

        protected override void BuildPillar()
        {
            Console.WriteLine("Adding wooden Pillars");
        }

        protected override void BuildWall()
        {
            Console.WriteLine("Building wooden walls");
        }

        protected override void LayFoundation()
        {
            Console.WriteLine("Adding wooden foundation");
        }
    }
}

