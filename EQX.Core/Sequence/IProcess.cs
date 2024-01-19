using EQX.Core.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EQX.Core.Sequence
{
    public interface IProcess<TERunMode> : IIdentifier, IProcessExecutor where TERunMode : Enum
    {
        /// <summary>
        /// Parent process of current process
        /// </summary>
        IProcess<TERunMode>? ParentProcess { get; }
        int AddChild(IProcess<TERunMode> child);

        EProcessMode ProcessMode { get; set; }
        EProcessStatus ProcessStatus { get; set; }

        int Step { get; set; }
        TERunMode RunMode { get; set; }

        bool Start();
        bool Stop();
    }
}
