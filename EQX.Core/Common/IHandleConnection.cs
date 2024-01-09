namespace EQX.Core.Common
{
    /// <summary>
    /// Initialize() -> Connect() -> ... -> Disconnect()
    /// </summary>
    public interface IHandleConnection
    {
        bool IsConnected { get; }

        /// <summary>
        /// Initialize setting before call the Connect function
        /// </summary>
        /// <returns>Initialize result</returns>
        bool Initialize();
        bool Connect();
        bool Disconnect();
    }
}
