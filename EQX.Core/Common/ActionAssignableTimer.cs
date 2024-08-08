namespace EQX.Core.Common
{
    public class ActionAssignableTimer
    {
        public string Name { get; }

        public void StartTimer(int intervalMs)
        {
            if (timer != null && timer.Enabled)
            {
                return;
            }

            timer = new System.Timers.Timer(intervalMs);
            timer.Elapsed += Timer_Elapsed;
            timer.Enabled = true;
        }

        private void Timer_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
        {
            count++;

            if (phaseNumber == 1)
            {
                foreach (var action in phase1Action)
                {
                    action.Value();
                }
            }
            else
            {
                foreach (var action in phase2Action)
                {
                    action.Value();
                }
            }
        }

        public void StopTimer()
        {

        }

        private Dictionary<string, Action> phase1Action;
        private Dictionary<string, Action> phase2Action;
        private System.Timers.Timer timer;
        private int count = 0;
        private int phaseNumber => count % 2;
    }
}
