namespace EQX.Core.Vision.Flow
{
    public interface IVisionFlowRepository
    {
        void Init(List<IVisionFlow> visionFlows);
        IEnumerable<IVisionFlow> GetAll();
    }
}
