using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Text;

namespace RabbitMqExample.TopicExchange
{
    internal class TopicExchangeConsumer
    {
        internal void CreateConsumer(ConnectionFactory connectionFactory, string exchangeName, string routingKeyPattern, string queueName, string consumerName)
        {
            using IConnection connection = connectionFactory.CreateConnection();
            using IModel channel = connection.CreateModel();

            channel.ExchangeDeclare(exchangeName, ExchangeType.Topic);
            channel.QueueDeclare(queueName, durable: true, exclusive: false, autoDelete: false, null);
            channel.QueueBind(queueName, exchangeName, routingKeyPattern);
            channel.BasicQos(0, 5, false); //Declared prefetch count 5

            var consumer = new EventingBasicConsumer(channel);
            consumer.Received += (sender, e) =>
            {
                var body = e.Body.ToArray();
                var msg = $"Topic Consumer :: {consumerName} - {Encoding.UTF8.GetString(body)}";
                Console.WriteLine(msg);
            };

            channel.BasicConsume(queueName, true, consumer);

            Console.ReadLine();
        }
    }
}
