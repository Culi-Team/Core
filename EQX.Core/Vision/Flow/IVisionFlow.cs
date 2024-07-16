using EQX.Core.Common;
using EQX.Core.Vision.Tool;
using System.Collections.ObjectModel;

namespace EQX.Core.Vision.Flow
{
    public interface IVisionFlow : IIdentifier, IAsyncRunable
    {
        ObservableCollection<IVisionTool> VisionTools { get; }
        ObservableCollection<VisionToolConnection> VisionToolConnections { get; }
        void Save();
    }
}