using EQX.Core.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EQX.Core.InOut
{
    public interface IAInput : IIdentifier
    {
        double Volt { get; }
        double Current { get; }
    }
}
