using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EQX.Core.Units
{
    public class Tray<TECellStatus> : ITray<TECellStatus> where TECellStatus : Enum
    {
        public TECellStatus this[int index]
        {
            get
            {
                return Cells[index].Status;
            }
            set
            {
                Cells[index].Status = value;
            }
        }

        public string Name { get; }

        public int Rows { get; set; }
        public int Columns { get; set; }
        public ETrayOrientation Orientation { get; set; }
        public IList<ITrayCell<TECellStatus>> Cells { get; set; }

        public Tray(string name)
        {
            Name = name;
        }

        public int GetColumn(int index)
        {
            return (index - 1) % Columns + 1;
        }

        public int GetRow(int index)
        {
            return (index - 1) / Columns + 1;
        }

        public void GenerateCells()
        {
            Cells = new ObservableCollection<ITrayCell<TECellStatus>>();

            switch (Orientation)
            {
                case ETrayOrientation.TopLeft:
                    for (int r = 1; r <= Rows; r++)
                    {
                        for (int c = 1; c <= Columns; c++)
                        {
                            Cells.Add(new TrayCell<TECellStatus>(Columns * (r - 1) + c));
                        }
                    }
                    break;
                case ETrayOrientation.TopRight:
                    for (int r = 1; r <= Rows; r++)
                    {
                        for (int c = Columns; c >= 1; c--)
                        {
                            Cells.Add(new TrayCell<TECellStatus>(Columns * (r - 1) + c));
                        }
                    }
                    break;
                case ETrayOrientation.BottomLeft:
                    for (int r = Rows; r >= 1; r--)
                    {
                        for (int c = 1; c <= Columns; c++)
                        {
                            Cells.Add(new TrayCell<TECellStatus>(Columns * (r - 1) + c));
                        }
                    }
                    break;
                case ETrayOrientation.BottomRight:
                    for (int r = Rows; r >= 1; r--)
                    {
                        for (int c = Columns; c >= 1; c--)
                        {
                            Cells.Add(new TrayCell<TECellStatus>(Columns * (r - 1) + c));
                        }
                    }
                    break;
                default:
                    break;
            }
        }

        #region Privates
        #endregion
    }
}
