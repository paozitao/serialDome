using DocumentFormat.OpenXml.Presentation;
using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace serialDome
{
    class ThresToLight
    {
        const float MINLIGHT = 0.01f;
        const float MAXLIGHT = 0.6f;
        SerialPort master;

        public ThresToLight(SerialPort master)
        {
            this.master = master;
        }

        public void SetThres(float cur_light)
        {
            if (MINLIGHT > cur_light)
            {

            }
            else if (MINLIGHT < cur_light && cur_light < 0.4)
            {

            }
        }

        private void SendThres(float data)
        {
            byte[] data_send = new byte[6];
            data_send[0] = (byte)Data_dir.TO_MCU;
            data_send[1] = (byte)Send_target.THRESHOLD;
            Buffer.BlockCopy(BitConverter.GetBytes((UInt32)(data / 0.796)), 0, data_send, 2, 4);
            if (master.IsOpen)
            {
                master.Write(data_send, 0, 6);
            }
            else
            {
                MessageBox.Show("串口未打开");
            }
        }
        private void SendDam(float data)
        {
            byte[] data_send = new byte[6];
            data_send[0] = (byte)Data_dir.TO_MCU;
            data_send[1] = (byte)Send_target.DAMPING;
            Buffer.BlockCopy(BitConverter.GetBytes((UInt32)(data / 0.796)), 0, data_send, 2, 4);
            if (master.IsOpen)
            {
                master.Write(data_send, 0, 6);
            }
            else
            {
                MessageBox.Show("串口未打开");
            }
        }
    }
}
