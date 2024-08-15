using EQX.Core.Units;

namespace EQX.Core.Test
{
    [TestClass]
    public class TrayTest
    {
        public enum ETrayCellStatus
        {
            /// <summary>
            /// Ready to work
            /// </summary>
            Ready = 0,

            /// <summary>
            /// There is no material in the cell
            /// </summary>
            Skip,
            /// <summary>
            /// To-Pick cell
            /// </summary>
            Picking,
            /// <summary>
            /// Pick done, material have been removed successed
            /// </summary>
            PickDone,
            /// <summary>
            /// Pick done with fail
            /// </summary>
            NGPickFail,
            /// <summary>
            /// Vision inspect with fail
            /// </summary>
            NGVision
        }

        [TestMethod]
        public void TestGetTrayRowColumnByStatus()
        {
            var tray = new Tray<ETrayCellStatus>("Test Tray");
            tray.Rows = 5;
            tray.Columns = 4;
            tray.GenerateCells();

            Assert.AreEqual(1, tray.GetRow(ETrayCellStatus.Ready));
            Assert.AreEqual(1, tray.GetColumn(ETrayCellStatus.Ready));

            Assert.AreEqual(-1, tray.GetRow(ETrayCellStatus.NGVision));
            Assert.AreEqual(-1, tray.GetColumn(ETrayCellStatus.NGVision));

            tray[7] = ETrayCellStatus.NGVision;

            Assert.AreEqual(2, tray.GetRow(ETrayCellStatus.NGVision));
            Assert.AreEqual(3, tray.GetColumn(ETrayCellStatus.NGVision));

            Assert.IsFalse(tray[7].Equals(ETrayCellStatus.Ready));
            Assert.IsTrue(tray[7].Equals(ETrayCellStatus.NGVision));
        }
    }
}
