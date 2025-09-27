namespace EQX.Core.InOut
{
    public interface IConveyor
    {
        bool IsError { get; }
        void Run();
        void Stop();
        void RunReverse();
    }
}
