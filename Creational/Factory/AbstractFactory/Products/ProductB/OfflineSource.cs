namespace AbstractFactoryPattern.Products.ProductB
{
    internal class OfflineSource : ISource
    {
        public string GetSourceType() => "This is offline course";
    }
}
