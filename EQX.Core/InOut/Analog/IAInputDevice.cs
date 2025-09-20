using EQX.Core.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EQX.Core.InOut
{
    public interface IAInputDevice : IIdentifier, IHandleConnection
    {
        List<IAInput> AnalogInputs { get; }
        void Initialize();

        double GetVolt(int channel);
        double GetCurrent(int channel);
    }
}
