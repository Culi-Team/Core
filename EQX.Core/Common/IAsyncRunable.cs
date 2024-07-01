namespace EQX.Core.Common
{
    public interface IAsyncRunable
    {
        ERunState State { get; }
        Task Run(int timeoutMs);
    }
}
