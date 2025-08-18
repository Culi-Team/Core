using EQX.Core.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EQX.Core.Device.SyringePump
{
    public interface ISyringePump : IHandleConnection , IIdentifier
    {
        void Reset();
        void Initialize();
        void Stop();
        void Dispense(double volume,int port);
        void Fill(double volume);
        void Home();
        void QueryStatus();
    }
}
