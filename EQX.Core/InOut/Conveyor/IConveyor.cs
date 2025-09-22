using EQX.Core.InOut;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EQX.Core.InOut
{
    public interface IConveyor
    {
        bool IsError { get; }
        void Run();
        void Stop();
        void RunReverse();
    }
}
