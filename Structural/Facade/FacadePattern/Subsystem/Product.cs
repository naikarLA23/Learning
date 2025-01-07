namespace FacadePattern.Subsystem
{
    internal class Product(string name)
    {
        protected string Name { get; set; } = name;

        internal void AddProduct()
        {
            Console.WriteLine($"Added product :{Name}");
        }
    }
}
