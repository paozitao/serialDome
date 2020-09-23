using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.IO.Ports;
using System.Threading;

enum Data_target : byte
{
	RATE_TX = (byte)'C',
	RATE_RX = (byte)'D',
	CN_TX = (byte)'E',
	CN_RX = (byte)'F',
	CN_BER = (byte)'G',
	POWER = (byte)'H',
	PMT = (byte)'I',
	TDD = (byte)'J',
	ANGLE_L = (byte)'K',
	ANGLE_V = (byte)'L',
	STATU = (byte)'M'
}

enum Send_target: byte
{
	START = (byte)'A',
	RESET = (byte)'B',
	RATE_TX = (byte)'C',
	RATE_RX = (byte)'D',
	MODE = (byte)'F',
	ANGLE_V = (byte)'G',
	ANGLE_L = (byte)'H',
	TDD = (byte)'I'
}

namespace serialDome
{
	public partial class Form1 : MetroForm
	{
		//串口接口功能类
		Info_interface info_interface = new Info_interface();
		
		private bool isOpen = false;

		private double[] yAxis = new double[20];
		private int n_point = 0;
		//缓存区最大区域：
		const int MAX = 500;
		//串口接收缓存区
		private byte[] r_buf = new byte[MAX];

		//未经处理的缓存区的byte数
		private int cn_byte = 0;

		//分析数据帧的参数
		byte[] frame = new byte[6];
		byte[] head = new byte[2];
		int start = 0;

		public Form1()
		{
			InitializeComponent();
			System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;
		}

		//页面加载初始化
		private void Form1_Load(object sender, EventArgs e)
		{


			chart1.Series[0].Points.AddY(0);

			//从机和设置panel的位置初始化，默认不可见
			pn_set.Location = new System.Drawing.Point(105, 75);
			pn_slave.Location = new System.Drawing.Point(105, 75);

		}



		//接受串口信号模块
		private void master_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
		{

			//等待100ms，等待各个数据帧发送完毕
			info_interface.InterfaceTest(this, master);
			Thread.Sleep(100);
			int n = master.BytesToRead;
			byte[] buf = new byte[n];
			master.Read(buf, 0, n);

			//当在100ms内只接收到一个数据帧时且缓存区无数据
			if (cn_byte == 0 && n == 6)
			{
				Buffer.BlockCopy(buf, 0, frame, 0, 6);
				info_interface.Analy(frame, this);
			}
			else
			{
				Buffer.BlockCopy(buf, 0, r_buf, cn_byte, n);

				//检验缓存区开始是否是正确的数据帧，不是则移动到下一个，直至出现正确的帧头
				Buffer.BlockCopy(r_buf, 0, head, 0, 2);
				while (!info_interface.head_test(head))
				{
					start++;
					Buffer.BlockCopy(r_buf, start, head, 0, 2);
				}
				
				//每六个byte块分析数据帧
				for (int i = 0; i < ((n + cn_byte - start) / 6); i++)
				{
					Buffer.BlockCopy(r_buf, start + (i * 6), frame, 0, 6);
					info_interface.Analy(frame, this);
				}

				//当出现剩余数据时，保存到缓存区中
				if ((n + cn_byte - start) % 6 != 0)
				{                  
					int rest_n = (n + cn_byte - start) % 6;
					//start帧头错误标志位复位
					start = 0;
					//复制剩余数据
					byte[] rest = new byte[rest_n];
					Buffer.BlockCopy(r_buf, n + cn_byte - rest_n, rest, 0, rest_n);
					//清空缓存区
					Array.Clear(r_buf, 0, MAX);
					//移动
					Buffer.BlockCopy(rest, 0, r_buf, 0, rest_n);
					cn_byte = rest_n;
				}
				else
				{
					start = 0;
					cn_byte = 0;
				}

			}

		}

			//选择串口
			private void switch_Click(object sender, EventArgs e)
		{
			//大小端测试
			//byte[] int1 = BitConverter.GetBytes((UInt32)1);
			//byte[] f1 = BitConverter.GetBytes((float)1.52f);
			//Console.WriteLine(int1[0]);
			//Console.WriteLine(int1[1]);
			//Console.WriteLine(int1[2]);
			//Console.WriteLine(int1[3]);
			//Console.WriteLine(f1[0]);
			//Console.WriteLine(f1[1]);
			//Console.WriteLine(f1[2]);
			//Console.WriteLine(f1[3]);
			if (sw_com.Text == null)
			{
				MessageBox.Show("未选择串口", "错误");
				
			}
			if (!isOpen)
			{
				try
				{
					master.PortName = sw_com.Text;
					master.Open();
					//清除接收缓存区
					master.DiscardInBuffer();
					swtich.Text = "关闭串口";
					swtich.Image = Properties.Resources.on;

					
					isOpen = true;
				}
				catch
				{
					//master.Close();
					//swtich_icon.BackgroundImage = Properties.Resources.off;
					MessageBox.Show("串口打开失败，请检查参数和连接", "错误");
				}
			}
			else
			{
				master.Close();
				swtich.Image= Properties.Resources.off;
				swtich.Text = "打开串口";
				isOpen = false;
			}

		}


		//设置对应文本框的数据
		public void set_text(byte target, string str)
		{
			switch (target)
			{
				case (byte)Data_target.RATE_TX:
					txRate.Text = str;
					break;
				case (byte)Data_target.RATE_RX:
					rxRate.Text = str;
					break;
				case (byte)Data_target.CN_TX:
					cn_tx.Text = str;
					break;
				case (byte)Data_target.CN_RX:
					cn_rx.Text = str;
					break;
				case (byte)Data_target.CN_BER:
					String[] data_ber = str.Split(',');
					ber_cn.Text = data_ber[0];
					ber.Text = data_ber[1];
					break;
				case (byte)Data_target.POWER:
					DrawLine(str);
					power.Text = str;
					break;
				case (byte)Data_target.PMT:
					txRate.Text = str;
					break;
				case (byte)Data_target.TDD:
					String[] data = str.Split(',');
					TDD_rate.Text = data[0];
					TDD_modu.Text = data[1];
					TDD_type.Text = data[2];
					TDD_ratio.Text = data[3];
					break;
				case (byte)Data_target.ANGLE_V:
					angle_v.Text = str;
					break;
				case (byte)Data_target.ANGLE_L:
					angle_l.Text = str;
					break;
				case (byte)Data_target.STATU:
					statu.Text = str;
					break;
				default:
					//帧结构出错、串口信息接收不全
					break;
			}
		}

		//发送软复位信号
		private void reset_Click(object sender, EventArgs e)
		{
			if (master.IsOpen)
			{
				info_interface.Send((byte)Send_target.RESET,"1", master);
			}
		}

		private void Send_start()
		{
			if (master.IsOpen)
			{
				info_interface.Send((byte)Send_target.START, "1", master);
			}
		}

		//画出实时的光强图
		private void DrawLine(string str)
		{
			chart1.Series[0].Points.AddY(Convert.ToDouble(str));
		}

		//清除图表数据
		private void draw_clear_Click(object sender, EventArgs e)
		{
			chart1.Series[0].Points.Clear();
			chart1.Series[0].Points.AddY(0);
		}
		//无逻辑代码

		//选择set设置窗口
		private void button4_Click_1(object sender, EventArgs e)
		{
			pn_master.Visible = false;
			pn_set.Visible = true;
			pn_slave.Visible = false;
		}
		//选择master信息窗口
		private void button2_Click(object sender, EventArgs e)
		{
			pn_master.Visible = true;
			pn_set.Visible = false;
			pn_slave.Visible = false;
		}
		//选择slave信息窗口
		private void button3_Click(object sender, EventArgs e)
		{
			pn_master.Visible = false;
			pn_set.Visible = false;
			pn_slave.Visible = true;
		}

		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void button4_Click(object sender, EventArgs e)
		{
			
		}

        private void sw_com_Click(object sender, EventArgs e)
        {
			sw_com.Items.Clear();
			//导入系统串口
			foreach (string vPortName in SerialPort.GetPortNames())
			{
				sw_com.Items.Add(vPortName);
			}
		}
    }
}
