using EQX.Core.Common;
using System.Collections.ObjectModel;

namespace EQX.Core.Vision.Algorithms
{
    public delegate void VisionFlowRunFinishedHandler(object sender, IObjectCollection result);
    public interface IVisionFlow : IIdentifier, IAsyncRunnable
    {
        double PixelSize { get; set; }
        ObservableCollection<IVisionTool> VisionTools { get; }
        ObservableCollection<VisionToolConnection> VisionToolConnections { get; }
        IObjectCollection Outputs { get; }
        event VisionFlowRunFinishedHandler VisionFlowRunFinished;
        void Save();
    }
}