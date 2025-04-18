namespace ChartApp.Server.TimeFeature
{
    public class TimerManager
    {
        private Action? _action;

        private const int TIME_FREQ_IN_MS = 10000;

        public DateTime TimerStarted { get; set; }
        public bool IsTimerStarted { get; set; }

        public void PrepareTimer(Action action)
        {
            _action = action;

            while (true)
            {
                _action();
                Thread.Sleep(TIME_FREQ_IN_MS);
            }
        }

        public void Execute(object? stateInfo)
        {
            _action();
            if ((DateTime.Now - TimerStarted).TotalSeconds > 100)
            {
                IsTimerStarted = false;
            }
        }
    }
}
