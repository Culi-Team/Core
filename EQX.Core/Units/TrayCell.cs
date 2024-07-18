namespace EQX.Core.Units
{
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
