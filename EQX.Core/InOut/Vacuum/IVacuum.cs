using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EQX.Core.Common;

namespace EQX.Core.InOut
{
    public interface IVacuum : IIdentifier
    {
        /// <summary>
        /// Output status for suction.
        /// </summary>
        bool IsSuctionOn { get; }

        /// <summary>
        /// Output status for blow/purge. May be false when no blow output exists.
        /// </summary>
        bool IsBlowOn { get; }

        /// <summary>
        /// Optional vacuum-detect input. Returns false when no input exists.
        /// </summary>
        bool IsVacuumDetected { get; }

        /// <summary>
        /// Indicates whether blow output is available.
        /// </summary>
        bool HasBlow { get; }

        /// <summary>
        /// Indicates whether vacuum-detect input is available.
        /// </summary>
        bool HasVacuumDetect { get; }

        void SuctionOn();
        void BlowOn();
        void Off();
    }
}
