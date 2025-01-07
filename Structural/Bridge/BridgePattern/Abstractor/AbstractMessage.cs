using BridgePattern.Implementor;

namespace BridgePattern.Abstractor
{
    internal abstract class AbstractMessage
    {
        protected IMessageSender _messageSender;
        public abstract void SendMessage(string message);
    }
}
