using EQX.Core.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EQX.Core.Device.SpeedController
{
    public interface ISpeedController : IHandleConnection , IIdentifier
    {
        void Start();
        void Stop();
        void SetDirection(bool isCW);
        void SetSpeed(int speed);
        void SetAcceleration(int acceleration);
        void SetDeceleration(int deceleration);
    }
}
