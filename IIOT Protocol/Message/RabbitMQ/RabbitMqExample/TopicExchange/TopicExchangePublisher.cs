using Newtonsoft.Json;
using RabbitMQ.Client;
using System.Text;

namespace RabbitMqExample.TopicExchange
{
    internal class TopicExchangePublisher
    {
        internal void CreateProducer(ConnectionFactory connectionFactory, string exchangeName, string routingKey)
        {
            Dictionary<string, object> exchangeArguments = new()
            {
                { "x-message-ttl", 30000 } //30 second
            };

            using IConnection connection = connectionFactory.CreateConnection();
            using IModel channel = connection.CreateModel();

            channel.ExchangeDeclare(exchangeName, ExchangeType.Topic, arguments: exchangeArguments);

            int count = 0;
            while (true)
            {
                var msg = new { Name = $"Topic Producer", Message = $"Hello Message - {count}" };
                var byteMsg = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(msg));

                channel.BasicPublish(exchangeName, routingKey, null, byteMsg);
                count++;
                Thread.Sleep(1000);
            }
        }
    }
}
