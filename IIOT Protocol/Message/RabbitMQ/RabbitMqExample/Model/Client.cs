namespace RabbitMqExample.Model
{
    internal class Client
    {
        public string ExchangeType { get; set; } = string.Empty;
        public Publisher Publisher { get; set; } = new();
        public List<Consumer> Consumers { get; set; } = new();
    }
}
