using CompositePattern.Interface;

namespace CompositePattern.Composite
{
    internal class DirectoryComponent(string name) : IFileSystemComponent
    {
        public string Name { get; set; } = name;

        public List<IFileSystemComponent> Components { get; set; } = new();

        public decimal DisplaySizeInKb()
        {
            var size = Components.Sum(c => c.DisplaySizeInKb());
            Console.WriteLine($"\nSize of directory {Name} = {size} Kb");
            Console.WriteLine($"------------------------------------------------------------------");
            return size;
        }

        public void AddComponent(IFileSystemComponent component)
        {
            Components.Add(component);
        }

        //public void RemoveComponent(IFileSystemComponent component)
        //{
        //}
    }
}
