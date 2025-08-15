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
        void SetTorque(int index , int torque);
        void Jog(int index, int speed, bool isForward);
        void Stop(int index);
        void SetSpeed(int index, int speed);
        void ResetAlarm(int index);
        void Run(int index);
    }
}
