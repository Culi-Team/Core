using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using log4net;

namespace EQX.Core.Common
{
    public class TCPCommunicator : IHandleConnection, IIdentifier
    {
        public int Id { get; init; }
        public string Name { get; init; }
        public bool IsConnected
        {
            get
            {
                if (tcpClient == null) return false;
                return tcpClient.Connected;
            }
        }

        public IPAddress IPAddress { get; protected set; }
        public int Port { get; protected set; }

        public TCPCommunicator(int index, string name, IPAddress iPAddress, int port)
        {
            Id = index;
            Name = name;
            IPAddress = iPAddress;
            Port = port;

            tcpClient = new Socket(SocketType.Stream, ProtocolType.Tcp);
            _log = LogManager.GetLogger(Name);
        }

        public bool Connect()
        {
            if (tcpClient.Connected)
            {
                tcpClient.Close();
                tcpClient = new Socket(SocketType.Stream, ProtocolType.Tcp);
            }

            IAsyncResult result = tcpClient.BeginConnect(IPAddress, Port, null, null);

            bool success = result.AsyncWaitHandle.WaitOne(2000, true);

            if (tcpClient.Connected)
            {
                tcpClient.EndConnect(result);
                return true;
            }
            else
            {
                tcpClient.Close();
                _log.Error($"Failed to connect device {Name}.");
                return false;
            }
        }

        public bool Disconnect()
        {
            tcpClient.Close();

            return !tcpClient.Connected;
        }

        public bool SendData(byte[] buffer, int size)
        {
            if (tcpClient.Connected == false) return false;

            int sendByte = tcpClient.Send(buffer, size, SocketFlags.None);

            return sendByte == size;
        }

        public async Task<string> ReadToAsync(string endOfData, int timeoutMs = 5000)
        {
            if (tcpClient.Connected == false) return string.Empty;

            int startMs = Environment.TickCount;

            string data = string.Empty;
            byte[] bytes;

            while (true)
            {
                bytes = new byte[1024];

                int bytesRec = tcpClient.Receive(bytes);
                data += Encoding.ASCII.GetString(bytes, 0, bytesRec);
                if (data.IndexOf(endOfData) > -1)
                {
                    return data;
                }

                if (Environment.TickCount - startMs > timeoutMs)
                {
                    return string.Empty;
                }

                await Task.Delay(2);
            }
        }

        public string ReadTo(string endOfData, int timeoutMs = 5000)
        {
            int startMs = Environment.TickCount;

            string data = string.Empty;
            byte[] bytes;

            while (true)
            {
                bytes = new byte[1024];

                int bytesRec = tcpClient.Receive(bytes);
                data += Encoding.ASCII.GetString(bytes, 0, bytesRec);
                if (data.IndexOf(endOfData) > -1)
                {
                    return data;
                }

                if (Environment.TickCount - startMs > timeoutMs)
                {
                    return string.Empty;
                }

                Thread.Sleep(2);
            }
        }

        public int ReadData(ref byte[] buffer)
        {
            if (tcpClient.Connected == false) return -1;

            return tcpClient.Receive(buffer);
        }

        protected Socket tcpClient;

        private readonly ILog _log;
    }
}
