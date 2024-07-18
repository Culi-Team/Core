using EQX.Core.Common;

namespace EQX.Core.Units
{
    public interface ITray<TECellStatus> : INameable where TECellStatus : Enum
    {
        TECellStatus this[uint index] { get; set; }

        /// <summary>
        /// Total row count
        /// </summary>
        int Rows { get; set; }
        /// <summary>
        /// Total column count
        /// </summary>
        int Columns { get; set; }
        /// <summary>
        /// First cell start position
        /// </summary>
        ETrayOrientation Orientation { get; set; }

        /// <summary>
        /// Cell list
        /// </summary>
        IList<ITrayCell<TECellStatus>> Cells { get; set; }

        /// <summary>
        /// Get Row number of cell by its index
        /// </summary>
        /// <param name="index">Index of cell</param>
        /// <returns>Row of the cell</returns>
        int GetRow(int index);

        /// <summary>
        /// Get Column number of cell by its index
        /// </summary>
        /// <param name="index">Index of cell</param>
        /// <returns>Column of the cell</returns>
        int GetColumn(int index);
    }
}
