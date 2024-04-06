namespace EQX.Core.Motion
{
    public interface IMotionFactory
    {
        IMotion Create(int id, string name);
    }
}
