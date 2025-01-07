namespace AbstractFactoryPattern.Products.ProductB
{
    internal class OnlineSource : ISource
    {
        public string GetSourceType() => "This is online course";
    }
}
