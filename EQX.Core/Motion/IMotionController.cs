namespace EQX.Core.Motion
{
    public interface IMotionController
    {
        ulong ControllerId { get; }

        bool IsConnected { get; }

        bool Connect();
        bool Disconnect();
    }
}
