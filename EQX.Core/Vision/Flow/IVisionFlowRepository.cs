namespace EQX.Core.Vision.Flow
{
    public interface IVisionFlowRepository
    {
        IEnumerable<IVisionFlow> GetAll();
    }
}
