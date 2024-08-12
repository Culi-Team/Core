using EQX.Core.Common;
using System.IO.Ports;

namespace EQX.Core.Communication
{
    public class SerialCommunicator : IHandleConnection, IIdentifier
    {
        #region Constructor(s)
        public SerialCommunicator(int id, string name, string comPort, int baudRate = 115200, Parity parity = Parity.None, int dataBits = 8, StopBits stopBits = StopBits.One)
        {
            Id = id;
            Name = name;

            _comPort = comPort;
            _baudRate = baudRate;
            _parity = parity;
            _dataBits = dataBits;
            _stopBits = stopBits;
        }
        #endregion

        #region Properties
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsConnected => serialPort.IsOpen;
        /// <summary>
        /// Serial Comport Communicator
        /// </summary>
        /// <param name="id">Id</param>
        /// <param name="name">Name</param>
        /// <param name="comPort">Comport (ex: com1, com2,...)</param>
        /// <param name="baudRate">baudRate</param>
        /// <param name="parity">parity</param>
        /// <param name="dataBits">dataBits</param>
        /// <param name="stopBits">stopBits</param>
        #endregion

        #region Method(s)
        public bool Connect()
        {
            try
            {
                if (serialPort == null)
                {
                    serialPort = new SerialPort(_comPort, _baudRate, _parity, _dataBits, _stopBits);
                }

                serialPort.Open();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Disconnect()
        {
            if (serialPort == null) return true;
            if (serialPort.IsOpen)
            {
                serialPort.Close();
            }

            return true;
        }

        public void Write(string message)
        {
            serialPort.Write(message);
        }

        public void WriteLine(string message)
        {
            serialPort.WriteLine(message);
        }

        public string ReadLine()
        {
            return serialPort.ReadLine();
        }

        public string Read()
        {
            int bytes = serialPort.BytesToRead;

            byte[] buffer = new byte[bytes];
            serialPort.Read(buffer, 0, bytes);

            return System.Text.Encoding.Default.GetString(buffer);
        }
        #endregion

        #region Privates
        private SerialPort serialPort;
        private readonly string _comPort;
        private readonly int _baudRate;
        private readonly Parity _parity;
        private readonly int _dataBits;
        private readonly StopBits _stopBits;
        #endregion
    }
}
