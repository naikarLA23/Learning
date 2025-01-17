namespace RabbitMqExample.Model
{
    internal class Consumer
    {
        public string ExchangeName { get; set; } = string.Empty;
        public string QueueName { get; set; } = string.Empty;
        public string BindingKey { get; set; } = string.Empty;
        public string ConsumerName { get; set; } = string.Empty;
        public Dictionary<string, object> ConsumerHeader { get; set; } = new();
    }
}
