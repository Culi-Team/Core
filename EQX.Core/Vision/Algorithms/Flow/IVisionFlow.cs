using EQX.Core.Common;
using System.Collections.ObjectModel;

namespace EQX.Core.Vision.Algorithms
{
    public delegate void VisionFlowRunFinishedHandler(object sender, IObjectCollection result);
    public interface IVisionFlow : IIdentifier, IAsyncRunnable
    {
        event VisionFlowRunFinishedHandler VisionFlowRunFinished;
        event EventHandler SaveVisionFlowHandler;

        double PixelSize { get; set; }
        ObservableCollection<IVisionTool> VisionTools { get; }
        ObservableCollection<VisionToolConnection> VisionToolConnections { get; }
        IObjectCollection Outputs { get; }
        void Save();
    }
}