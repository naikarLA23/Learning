using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Text;

namespace RabbitMqExample.DirectExchange
{
    internal class DirectExchangeConsumer
    {
        internal void CreateConsumer(ConnectionFactory connectionFactory, string exchangeName, string routingKey, string queueName, string consumerName)
        {
            using IConnection connection = connectionFactory.CreateConnection();
            using IModel channel = connection.CreateModel();

            channel.QueueDeclare(queueName, durable: true, exclusive: false, autoDelete: false, null);
            channel.QueueBind(queueName, exchangeName, routingKey);
            channel.BasicQos(0, 5, false); //Declared prefetch count 5

            var consumer = new EventingBasicConsumer(channel);
            consumer.Received += (sender, e) =>
            {
                var body = e.Body.ToArray();
                var msg = $"Direct Consumer : {consumerName} - {Encoding.UTF8.GetString(body)}";
                Console.WriteLine(msg);
            };

            channel.BasicConsume(queueName, true, consumer);

            Console.ReadLine();
        }
    }
}
