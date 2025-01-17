using RabbitMQ.Client;
using RabbitMqExample.Model;

namespace RabbitMqExample.TopicExchange
{
    internal class ClientForTopicExchange
    {
        public static void Test(string uri, Client client)
        {
            ConnectionFactory connectionFactory = new()
            {
                Uri = new Uri(uri)
            };
            using IConnection connection = connectionFactory.CreateConnection();
            using IModel channel = connection.CreateModel();

            Task.Run(() => {
                TopicExchangePublisher tPublisher = new();
                tPublisher.CreateProducer(connectionFactory, client.Publisher.ExchangeName, client.Publisher.RoutingKey);
            });


            foreach (var consumer in client.Consumers)
            {
                Task.Run(() => {
                    TopicExchangeConsumer tConsumer = new();
                    tConsumer.CreateConsumer(connectionFactory, consumer.ExchangeName, consumer.BindingKey, consumer.QueueName, consumer.ConsumerName);

                });
            }
           // Task.WhenAll();
        }
    }
}
