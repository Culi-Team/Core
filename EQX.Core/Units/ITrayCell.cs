using EQX.Core.Common;
using System.Windows.Input;

namespace EQX.Core.Units
{
    public delegate void CellClickedEventHandler<TECellStatus>(uint id, TECellStatus beforeClickStatus) where TECellStatus : Enum;

    public interface ITrayCell<TECellStatus> : IIndexer where TECellStatus : Enum
    {
        event CellClickedEventHandler<TECellStatus> CellClicked;
        ICommand CellClickedCommand { get; }

        TECellStatus Status { get; set; }
    }
}
