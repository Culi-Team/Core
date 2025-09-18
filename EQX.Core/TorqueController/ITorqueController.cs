using EQX.Core.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EQX.Core.TorqueController
{
    public interface ITorqueController : IIdentifier, IHandleConnection
    {
        void SetTorque(double torque);
        void Jog(int speed, bool isForward);
        void Stop();
        void SetSpeed(int speed);
        void ResetAlarm();
        void Run();
    }
}
