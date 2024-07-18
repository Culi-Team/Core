using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Windows.Input;

namespace EQX.Core.Units
{
    public class TrayCell<TECellStatus> : ObservableObject, ITrayCell<TECellStatus> where TECellStatus : Enum
    {
        public event CellClickedEventHandler<TECellStatus> CellClicked;

        public ICommand CellClickedCommand { get; }

        public TECellStatus Status { get; set; }
        public int Id { get; }

        public TrayCell(uint id)
        {
            Id = (int)id;

            CellClickedCommand = new RelayCommand(() =>
            {
                CellClicked?.Invoke((uint)Id, Status);
                OnPropertyChanged(nameof(Status));
            });
        }
    }
}
