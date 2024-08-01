using EQX.Core.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EQX.Core.LightController
{
    public interface ILightController : IIdentifier, IHandleConnection
    {
        bool SetLightLevel(int channel, int value);
        bool SetLightStatus(int channel, bool bOnOff);

        int GetLightLevel(int channel);
        bool GetLightStatus(int channel);
    }
}
