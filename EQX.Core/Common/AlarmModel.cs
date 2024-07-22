using System.Drawing;

namespace EQX.Core.Common
{
    public class AlarmModel
    {
        public int Id { get; set; }
        public string Message { get; set; }

        public string AlarmOverviewSource { get; set; }
        public Rectangle AlarmOverviewHighlightRectangle { get; set; }

        public string AlarmDetailviewSource { get; set; }
        public Rectangle AlarmDetailviewHighlightRectangle { get; set; }

        public List<string> TroubleshootingSteps { get; set; }
    }
}
