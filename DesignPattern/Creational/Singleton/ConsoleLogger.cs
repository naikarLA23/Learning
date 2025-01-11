namespace SingletonPattern.SingletonPattern
{
    internal sealed class ConsoleLoggerWithDoubleCheckLock
    {
        private static ConsoleLoggerWithDoubleCheckLock? _Instance;
        private static int _Counter;

        private static readonly object _lockObj = new();

        public static ConsoleLoggerWithDoubleCheckLock GetInstance
        {
            get
            {
                if (_Instance == null)
                {
                    lock (_lockObj)
                    {
                        if (_Instance == null)
                            _Instance = new ConsoleLoggerWithDoubleCheckLock();
                    }
                }
                return _Instance;
            }
        }

        private ConsoleLoggerWithDoubleCheckLock()
        {
            _Counter++;
            Console.WriteLine($"{Environment.NewLine}Call from ConsoleLoggerWithDoubleCheckLock constructor.{Environment.NewLine}Instance Counter = {_Counter}");
        }

    }

    internal sealed class ConsoleLoggerWithLazyParam
    {
        private static int _Counter;

        public static readonly Lazy<ConsoleLoggerWithLazyParam> _Instance = new Lazy<ConsoleLoggerWithLazyParam>(() => new ConsoleLoggerWithLazyParam());

        private static readonly object _lockObj = new();

        public static ConsoleLoggerWithLazyParam GetInstance
        {
            get
            {
                return _Instance.Value;
            }
        }

        private ConsoleLoggerWithLazyParam()
        {
            _Counter++;
            Console.WriteLine($"{Environment.NewLine}Call from ConsoleLoggerWithLazyParam constructor.{Environment.NewLine}Instance Counter = {_Counter}");
        }
    }
}
