namespace EQX.Core.Common
{
    public interface IRunable
    {
        ERunState State { get; }
        void Run();
    }
}
