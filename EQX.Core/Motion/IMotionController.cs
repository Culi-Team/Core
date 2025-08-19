namespace EQX.Core.Motion
{
    public interface IMotionController
    {
        bool IsConnected { get; }

        bool Connect();
        bool Disconnect();
    }
}
