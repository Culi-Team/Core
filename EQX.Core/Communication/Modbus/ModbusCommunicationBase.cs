using NModbus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EQX.Core.Communication.Modbus
{
    public class ModbusCommunicationBase : IModbusCommunication
    {
        public virtual bool IsConnected { get; }

        public virtual IModbusMaster ModbusMaster { get; protected set; }

        public virtual bool Connect()
        {
            return true;
        }
        public virtual bool Disconnect()
        {
            return true;
        }
    }
}
