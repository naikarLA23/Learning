namespace Nlogger
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Logger.LogFatal("Logging FATAL message");
            Logger.LogError("Logging ERROR message");
            Logger.LogWarning("Logging WARNING message");
            Logger.LogDebug("Logging DEBUG message");
            Logger.LogInfo("Logging INFO message");
            Logger.LogTrace("Logging TRACE message");

            Console.ReadLine();
        }
    }
}
