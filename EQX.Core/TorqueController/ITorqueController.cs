using EQX.Core.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EQX.Core.TorqueController
{
    public enum TorqueControlMode
    {
        SpeedMode = 0,
        TorqueMode = 1
    }

    public interface ITorqueController : IIdentifier, IHandleConnection
    {
        void SetTorque(int torque);
        void SetSpeed(int speed);

        int GetValue();

        void Jog(int speed, bool isForward);

        void Run(bool isForward = true);
        void Stop();

        void ResetAlarm();
    }
}
