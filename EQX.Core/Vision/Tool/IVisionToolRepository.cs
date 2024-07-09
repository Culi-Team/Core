using EQX.Core.Vision.Tool;

namespace EQX.Core.Vision
{
    public interface IVisionToolRepository
    {
        IEnumerable<IVisionTool> GetAll();
    }
}
