using BridgePattern.Implementor;

namespace BridgePattern.Abstractor
{
    internal class ShortMessage : AbstractMessage
    {
        public ShortMessage(IMessageSender messageSender)
        {
            _messageSender = messageSender;
        }
        public override void SendMessage(string message)
        {
            if (message.Length <= 10)
            {
                Console.WriteLine($"Sending short message...");
                _messageSender.SendMessage($"\n{message}");
            }
            else
                Console.WriteLine($"Unable to send below short message...\n\n{message}.\n\n Size to big, max supported size is 10 character. \n Posted messagge size is {message.Length} character");
        }
    }
}
