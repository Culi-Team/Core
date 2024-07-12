using EQX.Core.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EQX.Core.InOut
{
    public interface ICylinder
    {
        bool IsForward { get; }
        bool IsBackward { get; }
        void MoveForward();
        void MoveBackward();
    }
}
