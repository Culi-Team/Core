using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EQX.Core.Vision
{
    public enum EVisionJudge
    {
        NG = -1,
        OK = 1
    }
    public interface IVisionResult
    {
        EVisionJudge Judge { get; }
    }
}
