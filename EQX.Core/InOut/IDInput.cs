using EQX.Core.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EQX.Core.InOut
{
    /// <summary>
    /// Digital input contact (single contact)
    /// </summary>
    public interface IDInput : IIdentifier
    {
        bool Value { get; }
    }
}
