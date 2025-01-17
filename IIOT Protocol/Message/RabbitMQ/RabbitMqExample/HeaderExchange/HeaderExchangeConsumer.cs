using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Text;

namespace RabbitMqExample.HeaderExchange
{
    internal class HeaderExchangeConsumer
    {
        internal void CreateConsumer(ConnectionFactory connectionFactory, string exchangeName, Dictionary<string, object> header,  string queueName, string consumerName)
        {
            using IConnection connection = connectionFactory.CreateConnection();
            using IModel channel = connection.CreateModel();
            channel.ExchangeDeclare(exchangeName, ExchangeType.Headers);
            channel.QueueDeclare(queueName, durable: true, exclusive: false, autoDelete: false, null);
            channel.QueueBind(queueName, exchangeName, string.Empty, header);
            channel.BasicQos(0, 5, false); //Declared prefetch count 5

            var consumer = new EventingBasicConsumer(channel);
            consumer.Received += (sender, e) =>
            {
                var body = e.Body.ToArray();
                var msg = $"Header Consumer : {consumerName} - {Encoding.UTF8.GetString(body)}";
                Console.WriteLine(msg);
            };

            channel.BasicConsume(queueName, true, consumer);

            Console.ReadLine();
        }
    }
}
