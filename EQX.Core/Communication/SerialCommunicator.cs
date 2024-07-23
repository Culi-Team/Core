using EQX.Core.Common;
using System.IO.Ports;

namespace EQX.Core.Communication
{
    public class SerialCommunicator : IHandleConnection, IIdentifier
    {
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
        public SerialCommunicator(int id, string name, string comPort, int baudRate = 115200, Parity parity = Parity.None, int dataBits = 8, StopBits stopBits = StopBits.One)
        {
            Id = id;
            Name = name;

            serialPort = new SerialPort(comPort, baudRate, parity, dataBits, stopBits);
        }

        public bool Connect()
        {
            try
            {
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

        private SerialPort serialPort;
    }
}
