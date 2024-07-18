namespace EQX.Core.Common
{
    public class AlarmModel
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public string AlarmOverviewSource { get; set; }
        public InfoRectangleDrawOnAlarm InfoRectangleDrawOnAlarmOverview { get; set; }
        public string AlarmDetailviewSource { get; set; }
        public InfoRectangleDrawOnAlarm InfoRectangleDrawOnAlarmDetailview { get; set; }
        public List<string> TroubleshootingSteps { get; set; }
        public string TroubleshootingStepToString
        {
            get
            {
                string ans = string.Empty;
                for (int i = 0; i < TroubleshootingSteps.Count - 1; ++i)
                {
                    ans += TroubleshootingSteps[i] + "=>";
                }
                ans += TroubleshootingSteps[TroubleshootingSteps.Count - 1];
                return ans;
            }
        }
    }
}
