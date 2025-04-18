namespace ChartApp.Client_Message.Model
{
    public class Message
    {
        public string Username { get; set; }
        public string MessageText { get; set; }
        public string Time { get; set; }

        public Message(string user, string text, string time)
        {
            Username = user;
            MessageText = text;
            Time = time;
        }
    }
}
