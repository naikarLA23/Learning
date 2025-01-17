using Newtonsoft.Json;
using RabbitMQ.Client;
using System.Text;

namespace RabbitMqExample.FanoutExchange
{
    internal class FanoutExchangePublisher
    {
        internal void CreateProducer(ConnectionFactory connectionFactory, string exchangeName, string routingKey)
        {
            Dictionary<string, object> exchangeArguments = new()
            {
                { "x-message-ttl", 30000 } //30 second
            };

            using IConnection connection = connectionFactory.CreateConnection();
            using IModel channel = connection.CreateModel();

            channel.ExchangeDeclare(exchangeName, ExchangeType.Fanout, arguments: exchangeArguments);

            int count = 0;
            while (true)
            {
                var msg = new { Name = $"Fanout Producer", Message = $"Hello Message - {count}" };
                var byteMsg = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(msg));
                channel.BasicPublish(exchangeName, string.Empty, null, byteMsg);
                count++;
                Thread.Sleep(1000);
            }
        }
    }
}
