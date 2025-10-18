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
        void SetSpeed(int speed);
        void SetAcceleration(int accCode);
        void SetDeccelation(int decCode);

        bool IsReady();
    }
}
