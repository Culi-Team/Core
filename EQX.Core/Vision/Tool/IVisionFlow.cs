using EQX.Core.Common;

namespace EQX.Core.Vision.Tool
{
    public interface IVisionFlow : IIdentifier, IRunable
    {
        List<IVisionTool> VisionTools { get; }
        List<VisionToolConnection> VisionToolConnections { get; }
    }
}