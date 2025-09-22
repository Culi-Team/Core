using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EQX.Core.InOut.Conveyor
{
    public interface IConveyorFactory
    {
        IConveyor Create(IDInput? inError, IDOutput? outRun, IDOutput? outReverseRun, IDOutput? outStop);
    }
}
