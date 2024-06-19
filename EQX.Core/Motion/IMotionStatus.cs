using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EQX.Core.Motion
{
    public interface IMotionStatus
    {
        bool IsAlarm { get; }

        bool IsMotionOn { get; }
        bool IsHomeDone { get; }
        bool IsMotioning { get; }

        bool HwPosLimitDetect { get; }
        bool HwNegLimitDetect { get; }

        double CommandPosition { get; }
        double ActualPosition { get; }
        double PositionError { get; }
        double ActualVelocity {  get; }
    }
}
