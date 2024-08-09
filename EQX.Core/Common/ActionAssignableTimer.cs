namespace EQX.Core.Common
{
    public class ActionAssignableTimer
    {
        public ActionAssignableTimer(int intervalMs)
        {
            _intervalMs = intervalMs;
            phase1Actions = new Dictionary<string, Action>();
            phase2Actions = new Dictionary<string, Action>();

            StartTimer(intervalMs);
        }

        private void StartTimer(int intervalMs)
        {
            if (timer != null && timer.Enabled)
            {
                return;
            }

            timer = new System.Timers.Timer(intervalMs);
            timer.Elapsed += Timer_Elapsed;
            timer.Enabled = true;
        }

        public void EnableAction(string identityKey, Action phase1Action, Action phase2Action)
        {
            if (phase1Actions.ContainsKey(identityKey) == false && phase1Action != null)
            {
                phase1Actions.Add(identityKey, phase1Action);
            }
            if (phase2Actions.ContainsKey(identityKey) == false && phase2Action != null)
            {
                phase2Actions.Add(identityKey, phase2Action);
            }
        }

        public void DisableAction(string identityKey)
        {
            phase1Actions.Remove(identityKey);
            phase2Actions.Remove(identityKey);
        }

        private void Timer_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
        {
            count++;

            if (phaseNumber == 1)
            {
                foreach (var action in phase1Actions)
                {
                    action.Value();
                }
            }
            else
            {
                foreach (var action in phase2Actions)
                {
                    action.Value();
                }
            }
        }

        public void StopTimer()
        {
            phase1Actions.Clear();
            phase2Actions.Clear();

            timer.Stop();
            timer.Dispose();
        }

        private readonly int _intervalMs;
        private Dictionary<string, Action> phase1Actions;
        private Dictionary<string, Action> phase2Actions;
        private System.Timers.Timer timer;
        private int count = 0;
        private int phaseNumber => count % 2;
    }
}
