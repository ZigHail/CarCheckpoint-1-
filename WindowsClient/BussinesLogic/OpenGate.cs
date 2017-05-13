using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsClient.BussinesLogic
{
    public class OpenGate
    {
        static bool firstOpen = true;
        //public static void Open(string cardId, string arduinoPortName)
        //{
        //    //new Action(SendCommandToArduino).BeginInvoke(null, null);
        //}

        public static void Open()
        {
            new Action(SendCommandToArduino).BeginInvoke(null, null);
        }

        private static void SendCommandToArduino()
        {
            const int isReady = 4, end = 5;            
            SerialPort serialPort1 = new SerialPort()
            {
                PortName = "COM3",
                BaudRate = 9600
            };

            if (!serialPort1.IsOpen)
                serialPort1.Open();

            if (serialPort1.IsOpen)
                serialPort1.Write("5");

            serialPort1.DiscardInBuffer();
            if (firstOpen)
            {
                firstOpen = false;
                serialPort1.Close();
                return;
            }
           
            var answer = serialPort1.ReadChar();            

            for (int i = 0; i < 15; i++)
            {
                answer = serialPort1.ReadChar();
                if (answer == end)
                {
                    serialPort1.Close();
                    break;
                }
                else if (answer == isReady)
                {
                    serialPort1.Close();
                    SendCommandToArduino();
                    break;
                }
                if (i == 14)
                {
                    serialPort1.Close();
                    break;
                }
            }
        }
    }
}
