using System.Diagnostics;

namespace EQX.Core.Display
{
    public class DisplayManager
    {
        public void EnableExtend()
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "DisplaySwitch.exe",
                Arguments = "/extend",
                UseShellExecute = true,
                CreateNoWindow = true
            });
        }
    }
}
