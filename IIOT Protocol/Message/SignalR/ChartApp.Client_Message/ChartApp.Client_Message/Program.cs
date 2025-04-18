using ChartApp.Client_Message.Model;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;

namespace ChartApp.Client_Message
{
    public class Program
    {
        static void Main(string[] args)
        {
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), "AppSettings.json");
            AppSetting appSetting = new AppSetting();

            if (File.Exists(filePath))
            {
                var data = File.ReadAllText(filePath);
                appSetting = JsonConvert.DeserializeObject<AppSetting>(data);
            }
            else
            {
                Console.WriteLine("appsettings.json file not found");
                return;
            }

            User user = ConfigureUser();
            StartSignalRConnection(appSetting, user);
        }

        private static void StartSignalRConnection(AppSetting appSetting, User user)
        {
            MessageClient msgClient = new(user, appSetting);
            msgClient.CreateConnection();
            string msgText = string.Empty;
            while (true)
            {
                msgText = Console.ReadLine().Trim();
                msgClient.SendMessage(msgText);
                Console.WriteLine($"Sent Mesage : {msgText}");
            }
        }

        private static User ConfigureUser()
        {
            User user = new() { };
            Console.WriteLine("Enter User name : ");
            user.Username = Console.ReadLine().Trim();

            Console.WriteLine("Enter Group name : ");
            user.GroupName = Console.ReadLine().Trim();

            Console.Title = $"{user.Username}_{user.GroupName}";
            return user;
        }
    }
}
