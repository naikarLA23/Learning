using BridgePattern.Implementor;

namespace BridgePattern.Abstractor
{
    internal class LongMessage : AbstractMessage
    {
        public LongMessage(IMessageSender messageSender)
        {
            _messageSender = messageSender;
        }

        public override void SendMessage(string message)
        {
            if (message.Length <= 100)
            {
                Console.WriteLine($"Sending long message...");
                _messageSender.SendMessage($"\n{message}");
            }
            else
                Console.WriteLine($"Unable to send below long message...\n\n{message}.\n\n Size to big, max supported size is 100 character. \n Posted messagge size is {message.Length} character");
        }
    }
}