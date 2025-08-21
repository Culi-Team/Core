using EQX.Core.Common;
using NModbus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EQX.Core.Communication.Modbus
{
    public interface IModbusCommunication : IHandleConnection
    {
        bool IsConnected { get; }
        IModbusMaster ModbusMaster { get; }
    }
}
