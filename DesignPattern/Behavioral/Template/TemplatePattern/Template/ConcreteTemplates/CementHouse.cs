namespace TemplatePattern.Template.ConcreteTemplates
{
    internal class CementHouse : HouseTemplate
    {
        protected override void AddWindowsAndDoor()
        {
            Console.WriteLine("Adding doors and Windows to cement house");
        }

        protected override void BuildPillar()
        {
            Console.WriteLine("Adding cement Pillars");
        }

        protected override void BuildWall()
        {
            Console.WriteLine("Building cement walls");
        }

        protected override void LayFoundation()
        {
            Console.WriteLine("Adding cement foundation");
        }
    }
}
