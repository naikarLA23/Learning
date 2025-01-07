using CompositePattern.Interface;

namespace CompositePattern.Leaf
{
    internal class FileLeaf(string name, decimal size) : IFileSystemComponent
    {
        public string Name { get; set; } = name;
        public decimal Size { get; set; } = size;

        public decimal DisplaySizeInKb()
        {
            var size = Size / 1024;
            Console.WriteLine($"Size of file {Name} = {size} Kb");
            return size;
        }
    }
}
