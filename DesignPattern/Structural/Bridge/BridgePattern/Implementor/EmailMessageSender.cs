namespace BridgePattern.Implementor
{
    internal class EmailMessageSender : IMessageSender
    {
        public void SendMessage(string message)
        {
            Console.WriteLine($"{message} \n\n This Message has been sent using EMail");
        }
    }
}