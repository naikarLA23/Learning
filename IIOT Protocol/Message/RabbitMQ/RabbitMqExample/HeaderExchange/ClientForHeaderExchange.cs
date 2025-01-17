using RabbitMQ.Client;
using RabbitMqExample.Model;
using RabbitMqExample.TopicExchange;

namespace RabbitMqExample.HeaderExchange
{
    internal class ClientForHeaderExchange
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
                HeaderExchangePublisher hPublisher = new();
                hPublisher.CreateProducer(connectionFactory, client.Publisher.ExchangeName, client.Publisher.RoutingKey, client.Publisher.ExchangeHeader);
            });


            foreach (var consumer in client.Consumers)
            {
                Task.Run(() => {
                    HeaderExchangeConsumer hConsumer = new();
                    hConsumer.CreateConsumer(connectionFactory, consumer.ExchangeName, consumer.ConsumerHeader, consumer.QueueName, consumer.ConsumerName);

                });
            }
            // Task.WhenAll();
        }
    }
}
