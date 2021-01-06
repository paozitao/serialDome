using System;
using System.Collections;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace serialDome
{
    class AutoChange
    {

        private uint tdd_num;
        private uint cn_error;
        private int present_dam,before_dam;

        private bool active;
        public bool dam_change;
        private SortedDictionary<int, uint> error_dic = new SortedDictionary<int, uint>();
        private int dam_interval;
        private int dam_init;

        private SerialPort master;

        private uint tdd_present=0,tdd_before=0,tdd_change;

        private int[] tdd_num_max_dam = new int[10];
        private byte[] data_send = new byte[6];
        private const float AD = 0.79609F;

        public AutoChange(int interval, int init, SerialPort master)
        {
            this.dam_interval = interval;
            this.dam_init = init;
            this.master = master;
            SendPreDam(init, master);
            active = true;
        }

        public bool IsActive()
        {
            return active;
        }
        private void SendPreDam(int dam, SerialPort master)
        {
            Array.Clear(data_send,0,6);
            this.present_dam = dam;
            data_send[0] = (byte)Data_dir.TO_MCU;
            data_send[1] = (byte)Send_target.DAMPING;
            Buffer.BlockCopy(BitConverter.GetBytes((UInt32)((this.present_dam) / AD)), 0, data_send, 2, 4);
            if(SendData(data_send, master))
            {
                dam_change = true;
            }
            else
            {
                active = false;
            }

        }
        
        public void SetError(uint cn_error)
        {
            error_dic.Add(present_dam, cn_error);
            SendPreDam(present_dam - dam_interval,master);
        }

        public void Check()
        {

        }
        private bool SendData(byte[] data, SerialPort master)
        {
            try
            {
                master.Write(data, 0, 6);
                return true;
            }
            catch
            {
                MessageBox.Show("串口发送失败，请检查连线", "Wrong");

                return false;
            }
        }

    }
}
