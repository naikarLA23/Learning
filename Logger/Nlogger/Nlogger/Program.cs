using System.Reflection;

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

            Logger.SetChangeFileProperties();
            Logger.LogDebug("Logging new 1 DEBUG message");

            Logger.RemoveTarget("file");

            var filePath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Logs", DateTime.Now.ToString("ddMMyyyy"));
            Logger.AddNewFileTarget(filePath, "NewApplication2.log");
            Logger.LogDebug("Logging new 2 DEBUG message");

            Console.ReadLine();
        }
    }
}
