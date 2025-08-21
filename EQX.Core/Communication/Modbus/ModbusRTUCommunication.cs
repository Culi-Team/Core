using NModbus;
using System.IO.Ports;
using NModbus.Serial;

namespace EQX.Core.Communication.Modbus
{
    public class ModbusRTUCommunication : ModbusCommunicationBase
    {
        public override bool IsConnected
        {
            get
            {
                if(serialPort == null)
                {
                    return false;
                }
                return serialPort.IsOpen;
            }
        }

        public override IModbusMaster ModbusMaster { get; protected set; }

        public ModbusRTUCommunication(string comPort, int baudRate = 9600, Parity parity = Parity.None, int dataBits = 8, StopBits stopBits = StopBits.One)
        {
            _comPort = comPort;
            _baudRate = baudRate;
            _parity = parity;
            _dataBits = dataBits;
            _stopBits = stopBits;
        }

        public override bool Connect()
        {
            try
            {
                if (serialPort == null)
                {
                    serialPort = new SerialPort(_comPort, _baudRate, _parity, _dataBits, _stopBits);
                }

                serialPort.Open();

                ModbusMaster = new ModbusFactory().CreateRtuMaster(serialPort);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public override bool Disconnect()
        {
            if (serialPort == null) return true;
            if (serialPort.IsOpen)
            {
                serialPort.Close();
            }

            return true;
        }

        #region Privates
        private readonly string _comPort;
        private readonly int _baudRate;
        private readonly Parity _parity;
        private readonly int _dataBits;
        private readonly StopBits _stopBits;

        private SerialPort serialPort;
        #endregion
    }
}
