using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EQX.Core.Motions
{
    public interface IMotion
    {
        int Id { get; }
        string Name { get; }

        bool IsConnected { get; }

        bool Connect();
        bool Disconnect();

        bool MotionOn();
        bool MotionOff();

        bool SearchOrigin();

        bool MoveInc(double position, double speed);
        bool MoveAbs(double position, double speed);

        bool Stop(bool forceStop = false);
    }
}
