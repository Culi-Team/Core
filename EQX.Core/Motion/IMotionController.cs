namespace EQX.Core.Motion
{
    public interface IMotionController
    {
        ulong DeviceId { get; }

        bool IsConnected { get; }

        bool Connect();
        bool Disconnect();
    }
}
