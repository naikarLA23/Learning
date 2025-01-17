using RabbitMQ.Client;
using RabbitMqExample.Model;

namespace RabbitMqExample.DirectExchange
{
    internal class ClientForDirectExchange
    {
        public static void Test(string uri, Client client)
        {
            ConnectionFactory connectionFactory = new()
            {
                Uri = new Uri(uri)
            };
          
            Task.Run(() => {
                DirectExchangePublisher dPublisher = new();
                dPublisher.CreateProducer(connectionFactory, client.Publisher.ExchangeName, client.Publisher.RoutingKey);
            });


            foreach (var consumer in client.Consumers)
            {
                Task.Run(() => {
                    DirectExchangeConsumer dConsumer = new();
                    dConsumer.CreateConsumer(connectionFactory, consumer.ExchangeName, consumer.BindingKey, consumer.QueueName, consumer.ConsumerName);

                });
            }
        }
    }
}
