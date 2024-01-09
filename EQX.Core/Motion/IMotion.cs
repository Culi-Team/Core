using EQX.Core.Common;

namespace EQX.Core.Motion
{
    public interface IMotion : IHandleConnection, IIdentifier
    {
        bool MotionOn();
        bool MotionOff();

        bool SearchOrigin();

        bool MoveInc(double position, double speed);
        bool MoveAbs(double position, double speed);

        bool Stop(bool forceStop = true);
    }
}
