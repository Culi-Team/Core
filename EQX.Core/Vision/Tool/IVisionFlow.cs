using EQX.Core.Common;
using System.Collections.ObjectModel;

namespace EQX.Core.Vision.Tool
{
    public interface IVisionFlow : IIdentifier, IRunable
    {
        ObservableCollection<IVisionTool> VisionTools { get; }
        ObservableCollection<VisionToolConnection> VisionToolConnections { get; }
    }
}