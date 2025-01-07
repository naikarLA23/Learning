namespace SingletonPattern.SingletonPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleLoggerWithDoubleCheckLock obj1;
            ConsoleLoggerWithLazyParam obj2;

            Parallel.Invoke(
                () => { obj1 = ConsoleLoggerWithDoubleCheckLock.GetInstance; },
                () => { obj1 = ConsoleLoggerWithDoubleCheckLock.GetInstance; },
                () => { obj1 = ConsoleLoggerWithDoubleCheckLock.GetInstance; });

            Parallel.Invoke(
                () => { obj2 = ConsoleLoggerWithLazyParam.GetInstance; },
                () => { obj2 = ConsoleLoggerWithLazyParam.GetInstance; },
                () => { obj2 = ConsoleLoggerWithLazyParam.GetInstance; });

            Console.WriteLine("Press Any Key to exit...............");
            Console.ReadKey();

        }
    }
}
