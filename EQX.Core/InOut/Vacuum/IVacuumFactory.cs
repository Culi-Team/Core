using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EQX.Core.InOut
{
    public interface IVacuumFactory
    {
        IVacuum Create(IDOutput? suctionOutput, IDOutput? blowOutput = null, IDInput? vacuumDetectInput = null);
    }
}
