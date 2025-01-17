namespace RabbitMqExample.Model
{
    internal class Publisher
    {
        public string ExchangeName { get; set; } = string.Empty;
        public string QueueName { get; set; } = string.Empty;
        public string RoutingKey { get; set; } = string.Empty;
        public Dictionary<string, object> ExchangeHeader { get; set; } = new();
    }
}
