using EQX.Core.Common;

namespace EQX.Core.Motion
{
    public interface IMotion : IHandleConnection, IIdentifier
    {
        IMotionStatus Status { get; }
        IMotionParameter Parameter { get; }

        bool Initialization();

        bool MotionOn();
        bool MotionOff();

        bool SearchOrigin();

        /// <summary>
        /// Move increase position
        /// </summary>
        /// <param name="position">Unit: mm</param>
        /// <param name="speed">Unit: mm/s</param>
        /// <returns></returns>
        bool MoveInc(double position, double speed);
        /// <summary>
        /// Move absolute position
        /// </summary>
        /// <param name="position">Unit: mm</param>
        /// <param name="speed">Unit: mm/s</param>
        /// <returns></returns>
        bool MoveAbs(double position, double speed);

        void MoveJog(double speed, bool isForward);

        bool Stop(bool forceStop = true);

        bool AlarmReset();
    }
}
