using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
