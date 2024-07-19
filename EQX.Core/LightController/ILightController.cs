using EQX.Core.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EQX.Core.LightController
{
    public interface ILightController : IIdentifier, ILogable
    {
        int NumberOfChannel { get; set; }
        bool Open();
        void Close();
        void SetLightLevel(int channel, int value);
        void SetLightStatus(int channel, bool bOnOff);

        int GetLightLevel(int channel);
        bool GetLightStatus(int channel);
    }
}
