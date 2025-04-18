using ChartApp.Client_Message.Model;
using Microsoft.AspNetCore.SignalR.Client;
using Newtonsoft.Json;

namespace ChartApp.Client_Message
{
    public class MessageClient
    {
        #region Class Variables
        private readonly User _user;
        private readonly AppSetting _appSetting;
        private HubConnection _connection;
        private HubConnectionBuilder _connectionBuilder; 
        #endregion

        #region ctor
        public MessageClient(User user, AppSetting appSetting)
        {
            _user = user;
            _appSetting = appSetting;
        } 
        #endregion

        #region Public Methods
        public void CreateConnection()
        {
            _connectionBuilder = new HubConnectionBuilder();
            _connection = _connectionBuilder.WithUrl(GetEndPoint()).WithAutomaticReconnect().Build();
            _connection.StartAsync().ContinueWith(task =>
            {
                if (task.IsFaulted)
                    Console.WriteLine("There was an error opening the connection:{0}", task.Exception.GetBaseException());
                else
                    Console.WriteLine("Connected");

            }).Wait();

            StartListening();
            SendMessage("Joined");
        }

        public void SendMessage(string msg)
        {
            var obj = new Message(_user.Username, msg, DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss")) { };
            _connection.InvokeAsync<Message>(_appSetting.ServerInvokeMethod, obj).ContinueWith(task =>
            {
                if (task.Result != null)
                {
                    if (task.IsFaulted)
                        Console.WriteLine("There was an error calling send: {0}", task.Exception.GetBaseException());
                    else
                    {
                        Console.WriteLine(task.Result);
                    }
                }
            });
        }
        #endregion

        #region Private Methods
        private string GetEndPoint() => $"{_appSetting.URL}/{_appSetting.HubName}";

        private void StartListening()
        {
            _connection.On(_appSetting.ClientListenerMethod, (Action<object>)((msg) =>
            {
                try
                {
                    DisplayMessage(msg);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }));
        }

        private static void DisplayMessage(object msg)
        {
            var result = JsonConvert.DeserializeObject<Message>(msg.ToString());
            Console.WriteLine($"\n{result.Username}  {result.Time} : {result.MessageText}");
        } 
        #endregion
    }
}
