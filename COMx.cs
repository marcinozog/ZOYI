using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZOYI
{
    internal class COMx
    {
        SerialPort? port;
        String portName = "";
        int baudrate;
        bool bConnected = false;

        /*
         * 
         */
        public COMx()
        {
            port = new SerialPort();
        }

        /*
         * 
         */
        public void connect(string com, int baud = 115200)
        {
            if (!bConnected)
            {
                portName = com;
                baudrate = baud;

                try
                {
                    port!.PortName = portName;
                    port.BaudRate = baudrate;
                    port.Parity = Parity.None;
                    port.DataBits = 8;
                    port.StopBits = StopBits.One;
                    port.ReadTimeout = SerialPort.InfiniteTimeout; // 500;

                    port.Open();

                    bConnected = true;
                }
                catch (Exception ex)
                {
                    throw new Exception($"COMx connect: {ex.Message}");
                }
            }
        }

        /*
         * 
         */
        public void disconnect()
        {
            if (port!.IsOpen)
                port.Close();

            bConnected = false;
        }

        /*
         * 
         */
        public int readByte()
        {
            int readByte = -1;

            if (bConnected)
            {
                try
                {
                    readByte = port!.ReadByte();
                }
                catch (TimeoutException) { throw new TimeoutException(); }
                catch (Exception ex) { throw new Exception($"COMx read: {ex.Message}"); }
            }

            return readByte;
        }

        /*
         * 
         */
        public async Task<int> readByteAsync()
        {
            int readByte = -1;

            if (bConnected)
            {
                readByte = await Task.Run(() => port!.ReadByte());
            }
            
            return readByte;
        }

        /*
         * 
         */
        public string PortName()
        {
            return portName;
        }

        /*
         * 
         */
        public bool isConnected()
        {
            return bConnected;
        }

        /*
         * 
         */
        public List<string> listCOMports()
        {
            return SerialPort.GetPortNames().ToList();
        }
    }
}
