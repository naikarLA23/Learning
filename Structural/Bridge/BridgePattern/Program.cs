using BridgePattern.Abstractor;
using BridgePattern.Implementor;

namespace BridgePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IMessageSender msgSender = new SmsMessageSender();
            AbstractMessage abstractMessage = new ShortMessage(msgSender);
            abstractMessage.SendMessage("Hi call me");

            Console.WriteLine("........................................................................");
            msgSender = new SmsMessageSender();
            abstractMessage = new ShortMessage(msgSender);
            abstractMessage.SendMessage("Hi, Are you planning a solo trip this weekend?");

            Console.WriteLine("........................................................................");
            msgSender = new EmailMessageSender();
            abstractMessage = new LongMessage(msgSender);
            abstractMessage.SendMessage("Hi, \n Please send the updated test result along with report summary");

            Console.WriteLine("........................................................................");
            msgSender = new EmailMessageSender();
            abstractMessage = new LongMessage(msgSender);
            abstractMessage.SendMessage("Hi, \n Please send the updated test result along with report summary. \nPlease share this report to customer as well. \nCreated task for newly observed defect in DevOps and track it till closer");

            Console.WriteLine("........................................................................");
            Console.Read();
        }
    }
}
