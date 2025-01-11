using NLog;

namespace Nlogger
{
    internal static class Logger
    {

        public static NLog.Logger NloggerObject { get; private set; }

        static Logger()
        {
           NloggerObject = LogManager.GetCurrentClassLogger();
        }

        public static void ConfigureLogger()
        {

        }

        internal static void LogFatal(string message)
        {
            NloggerObject.Fatal(message);
        }

        internal static void LogError(string message)
        {
            NloggerObject.Error(message);
        }

        internal static void LogWarning(string message)
        {
            NloggerObject.Warn(message);
        }

        internal static void LogDebug(string message)
        {
            NloggerObject.Debug(message);
        }

        internal static void LogInfo(string message)
        {
            NloggerObject.Info(message);
        }

        internal static void LogTrace(string message)
        {
            NloggerObject.Trace(message);
        }
    }
}
