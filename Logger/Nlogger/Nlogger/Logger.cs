using NLog;
using NLog.Config;
using NLog.Layouts;
using NLog.Targets;
using NLog.Targets.Wrappers;
using System.Reflection;

namespace Nlogger
{
    internal static class Logger
    {

        public static NLog.Logger NloggerObject { get; private set; }

        static Logger()
        {
           NloggerObject = LogManager.GetCurrentClassLogger();
        }

        internal static void SetChangeFileProperties()
        {
            var fileTarget = NloggerObject.Factory.Configuration.AllTargets.First(a => a.Name == "file") as FileTarget;
            fileTarget.FileName = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Logs", 
                DateTime.Now.ToString("ddMMyyyy"), "NewApplication.log");  

            var config = new LoggingConfiguration();
            var asyncFileTarget = new AsyncTargetWrapper(fileTarget);

            config.AddTarget("file", asyncFileTarget);
        }

        internal static void RemoveTarget(string name)
        {
            LogManager.Configuration.RemoveTarget(name);
        }

        internal static void AddNewFileTarget(string logPath, string logFileName)
        {
            var fileTarget = new FileTarget
            {
                CreateDirs = true,
                Layout = Layout.FromString("${date:format=yyyy-MM-dd HH\\:mm\\:ss.fffffff} ${level} ${message}"),
                FileName = String.Format("{0}\\{1}", logPath, logFileName),
                ArchiveFileName = Path.Combine(logPath, logFileName, "{#####}"),
                ArchiveNumbering = ArchiveNumberingMode.Sequence,
                ArchiveEvery = FileArchivePeriod.None,
                ArchiveAboveSize = 10 * 1024 * 1024,
                AutoFlush = true,
                ConcurrentWrites = false,
                BufferSize = 10240,
                Name="file"
            };
           
            LogManager.Configuration.AddTarget(fileTarget);
            var fileLoggingRule = new LoggingRule("*", LogLevel.Trace, fileTarget);
            LogManager.Configuration.LoggingRules.Add(fileLoggingRule);
            LogManager.ReconfigExistingLoggers();
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
