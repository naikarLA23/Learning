using Newtonsoft.Json;
using RabbitMQ.Client;
using System.Text;

namespace RabbitMqExample.HeaderExchange
{
    internal class HeaderExchangePublisher
    {
        internal void CreateProducer(ConnectionFactory connectionFactory, string exchangeName, string routingKey, Dictionary<string, object> header)
        {
            Dictionary<string, object> exchangeArguments = new()
            {
                { "x-message-ttl", 30000 } //30 second
            };

            using IConnection connection = connectionFactory.CreateConnection();
            using IModel channel = connection.CreateModel();

            channel.ExchangeDeclare(exchangeName, ExchangeType.Headers, arguments: exchangeArguments);

            int count = 0;
            while (true)
            {
                var msg = new { Name = $"Header Producer", Message = $"Hello Message - {count}" };
                var byteMsg = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(msg));
                var properties = channel.CreateBasicProperties();
                properties.Headers = header;
                channel.BasicPublish(exchangeName, string.Empty,  properties, byteMsg);
                count++;
                Thread.Sleep(1000);
            }
        }
    }
}
