namespace EQX.Core.Common
{
    public interface IAsyncRunable
    {
        ERunState State { get; }
        Task RunAsync(int timeoutMs);
        long ExecuteTime { get; }
    }
}
