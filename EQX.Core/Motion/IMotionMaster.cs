namespace EQX.Core.Motion
{
    public interface IMotionMaster
    {
        ulong ControllerId { get; }

        bool IsConnected { get; }

        bool Connect();
        bool Disconnect();
    }
}
