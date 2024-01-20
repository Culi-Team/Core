namespace EQX.Core.Common
{
    /// <summary>
    /// Initialize() -> Connect() -> ... -> Disconnect()
    /// </summary>
    public interface IHandleConnection
    {
        bool IsConnected { get; }
        
        bool Connect();
        bool Disconnect();
    }
}
