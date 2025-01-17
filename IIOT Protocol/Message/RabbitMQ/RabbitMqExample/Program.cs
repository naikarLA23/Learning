using Newtonsoft.Json;
using RabbitMqExample.DirectExchange;
using RabbitMqExample.FanoutExchange;
using RabbitMqExample.HeaderExchange;
using RabbitMqExample.Model;
using RabbitMqExample.TopicExchange;

namespace RabbitMqExample
{
    internal class Program
    {

        static void Main(string[] args)
        {
            var settingFilePath = Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json");
            if (File.Exists(settingFilePath))
            {
                string fileContent = File.ReadAllText(settingFilePath);
                AppSettings appSettings = JsonConvert.DeserializeObject<AppSettings>(fileContent);

                if (appSettings != null)
                {
                    var rabbitMq = appSettings.RabbitMq;
                    var url = rabbitMq != null ? $"{rabbitMq.Protocol}://{rabbitMq.UserName}:{rabbitMq.Password}@{rabbitMq.HostName}:{rabbitMq.Port}" : string.Empty;
                    if (appSettings.Clients != null)
                    {
                        foreach (var client in appSettings.Clients)
                        {
                            if (client.ExchangeType == "Direct")
                                ClientForDirectExchange.Test(url, client);
                            else if (client.ExchangeType == "Topic")
                                ClientForTopicExchange.Test(url, client);
                            else if (client.ExchangeType == "Header")
                                ClientForHeaderExchange.Test(url, client);
                            else if (client.ExchangeType == "Fanout")
                                ClientForFanoutExchange.Test(url, client);
                        }
                    }
                }
            }
            Console.ReadLine();
        }
    }
}