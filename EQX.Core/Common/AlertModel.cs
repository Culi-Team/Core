using System.Drawing;
using Newtonsoft.Json;

namespace EQX.Core.Common
{
    public class AlertModel
    {
        #region Properties
        public int Id { get; set; }
        public string Message { get; set; }
        public string AlertOverviewSource { get; set; }
        public Rectangle AlertOverviewHighlightRectangle { get; set; }
        public List<AlertShapeModel> AlertOverviewShapes { get; set; } = new();
        public string AlertDetailviewSource { get; set; }
        public Rectangle AlertDetailviewHighlightRectangle { get; set; }
        public List<AlertShapeModel> AlertDetailviewShapes { get; set; } = new();
        public List<string> TroubleshootingSteps { get; set; } = new();
        [JsonIgnore]
        public bool HasLegacyRectangles =>
            (AlertOverviewHighlightRectangle.Width > 0 && AlertOverviewHighlightRectangle.Height > 0) ||
            (AlertDetailviewHighlightRectangle.Width > 0 && AlertDetailviewHighlightRectangle.Height > 0);
        #endregion
    }

    public enum AlertShapeType
    {
        Rectangle,
        Circle
    }

    public class AlertShapeModel
    {
        public AlertShapeType Type { get; set; }
        public double Left { get; set; }
        public double Top { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        public double CenterX { get; set; }
        public double CenterY { get; set; }
        public double Radius { get; set; }
        public double StrokeThickness { get; set; } = 3;
        public double RotationDegrees { get; set; }

        [JsonIgnore]
        public double CanvasLeft => Type == AlertShapeType.Circle ? CenterX - Radius : Left;

        [JsonIgnore]
        public double CanvasTop => Type == AlertShapeType.Circle ? CenterY - Radius : Top;

        [JsonIgnore]
        public double CanvasWidth => Type == AlertShapeType.Circle ? Radius * 2 : Width;

        [JsonIgnore]
        public double CanvasHeight => Type == AlertShapeType.Circle ? Radius * 2 : Height;
    }
}
