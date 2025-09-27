using EQX.Core.Common;

namespace EQX.Core.Device.SyringePump
{
    public interface ISyringePump : IHandleConnection , IIdentifier
    {
        void Reset();
        void Initialize();
        void Stop();
        void Dispense(double volume,int port);
        void Fill(double volume);
        void Home();
        void QueryStatus();
        void SetSpeed(int speed);
    }
}
