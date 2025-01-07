namespace TemplatePattern.Template.ConcreteTemplates
{
    internal abstract class HouseTemplate
    {
        internal void BuildHouse()
        {
            LayFoundation();
            BuildPillar();
            BuildWall();
            AddWindowsAndDoor();

            Console.WriteLine("House is built...");
        }

        protected abstract void LayFoundation();
        protected abstract void BuildPillar();
        protected abstract void BuildWall();
        protected abstract void AddWindowsAndDoor();
    }
}
