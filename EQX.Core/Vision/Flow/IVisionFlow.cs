using EQX.Core.Common;
using EQX.Core.Vision.Tool;
using System.Collections.ObjectModel;

namespace EQX.Core.Vision.Flow
{
    public delegate void VisionFlowRunFinishedHandler(object sender, IObjectCollection result);
    public interface IVisionFlow : IIdentifier, IAsyncRunnable
    {
        ObservableCollection<IVisionTool> VisionTools { get; }
        ObservableCollection<VisionToolConnection> VisionToolConnections { get; }
        IObjectCollection Outputs { get; }
        event VisionFlowRunFinishedHandler VisionFlowRunFinished;
        void Save();
    }
}