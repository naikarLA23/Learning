namespace FluentInterfaceDesignPattern
{
    internal class Order
    {
        public List<Product> Products { get; } = [];
        public decimal TotalPrice => Products.Sum(p => p.Price);

        public Order AddProduct(Product product)
        {
            Products.Add(product);
            return this;
        }
        public Order RemoveProduct(Product product)
        {
            Products.Remove(product);
            return this;
        }
    }
}
