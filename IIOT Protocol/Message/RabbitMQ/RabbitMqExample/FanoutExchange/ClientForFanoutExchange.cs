using RabbitMQ.Client;
using RabbitMqExample.Model;

namespace RabbitMqExample.FanoutExchange
{
    internal class ClientForFanoutExchange
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
                FanoutExchangePublisher fPublisher = new();
                fPublisher.CreateProducer(connectionFactory, client.Publisher.ExchangeName, client.Publisher.RoutingKey);
            });


            foreach (var consumer in client.Consumers)
            {
                Task.Run(() => {
                    FanoutExchangeConsumer fConsumer = new();
                    fConsumer.CreateConsumer(connectionFactory, consumer.ExchangeName, consumer.QueueName, consumer.ConsumerName);

                });
            }
            // Task.WhenAll();
        }
    }
}
