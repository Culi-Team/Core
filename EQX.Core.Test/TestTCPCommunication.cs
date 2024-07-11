using EQX.Core.Common;
using System.Diagnostics;
using System.Net;

namespace EQX.Core.Test
{
    [TestClass]
    public class TestTCPCommunication
    {
        [TestMethod]
        public void TestConnectRepeat()
        {
            var communicator = new TCPCommunicator(1, "Test", IPAddress.Parse("192.168.1.192"), 54600);

            communicator.Connect();
            Debug.WriteLine(communicator.IsConnected);
            //communicator.Connect();
        }
    }
}