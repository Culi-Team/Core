using EQX.Core.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EQX.Core.Units
{
    public interface ITrayCell<TECellStatus> : IIndexer where TECellStatus : Enum
    {
        TECellStatus Status { get; set; }
    }

    public class TrayCell<TECellStatus> : ITrayCell<TECellStatus> where TECellStatus : Enum
    {
        public TECellStatus Status { get; set; }
        public int Id { get; }

        public TrayCell(int id)
        {
            Id = id;
        }
    }
}
