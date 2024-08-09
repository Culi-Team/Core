using EQX.Core.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EQX.Core.InOut
{

    public interface ICylinder : IIdentifier
    {
        ECylinderType CylinderType { get; set; }

        bool IsForward { get; }
        bool IsBackward { get; }
        void Forward();
        void Backward();
    }
}
