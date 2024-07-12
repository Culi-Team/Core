namespace EQX.Core.Common
{
    public class AlarmModel
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public string AlarmOverviewSource { get; set; }
        public string AlarmDetailviewSource { get; set; }
        public List<string> TroubleshootingSteps { get; set; }
    }
}
