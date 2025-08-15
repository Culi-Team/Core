using EQX.Core.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EQX.Core.Device.Regulator
{
    public interface IRegulator : IIdentifier, IHandleConnection
    {
        bool SetPressure(double value);
        bool IncreasePressure();
        bool DecreasePressure();
        double GetPressure();
    }
}
