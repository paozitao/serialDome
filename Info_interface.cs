using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Windows.Forms;

namespace serialDome
{
	class Info_interface
	{

		//信息接口函数，接受信息：提取信息帧数据（返回字符串）
		//发送功能：生成发送数据帧

		//发送数据帧的缓存区
		private byte[] data_send = new byte[6];
		private byte[] f_head = new byte[2];
		private int i;

		//相关数据参数
		private  bool isReceive = false;
		private uint cn_rx = 0;

		//power和pmt是离散值，未经过量化，设置量化参数
		private const float POWER = 0.01F;
		private const float PMT = 0.01F;

		//验证帧头是否符合“3A-3M”
		public bool head_test(byte [] head)
		{
			if(head[0] != Convert.ToByte('3'))
			{
				return false;
			}
			else if (head[1]<65 || head[1]>77)
			{
				return false;
			}
			else
			{
				return true;
			}
		}

		//提取信息帧数据，并设置到响应的控件中
		//参数
		//data:接收的数据帧
		public bool Analy(byte[] frame,Form1 target)
		{
			Buffer.BlockCopy(frame, 0, f_head, 0, 2);
			if (head_test(f_head))
			{
				string str;
				switch (frame[1])
				{

					case (byte)Data_target.RATE_TX:
						target.set_text(frame[1], BitConverter.ToUInt32(frame, 2).ToString());
 						break;
					case (byte)Data_target.RATE_RX:
						target.set_text(frame[1], BitConverter.ToUInt32(frame, 2).ToString());
						break;
					case (byte)Data_target.CN_TX:
						target.set_text(frame[1], BitConverter.ToUInt32(frame, 2).ToString());
						break;
					case (byte)Data_target.CN_RX:
						cn_rx = BitConverter.ToUInt32(frame, 2);
						isReceive = true;
						target.set_text(frame[1], BitConverter.ToUInt32(frame, 2).ToString());
						break;
					case (byte)Data_target.CN_BER:
						//加入计算误码率的逻辑，判断接收总量数据是否收到
						if (isReceive && cn_rx != 0)
						{
							float ber = (float)BitConverter.ToUInt32(frame, 2) / (float)cn_rx;
							str = BitConverter.ToUInt32(frame, 2).ToString() + "," + ber.ToString();
							target.set_text(frame[1], str);
						}
						break;
					case (byte)Data_target.POWER:
						//需要进行转换，离散值乘以系数才是结构
						target.set_text(frame[1], (BitConverter.ToUInt32(frame, 2)*POWER).ToString());
						break;
					case (byte)Data_target.PMT:
						target.set_text(frame[1], (BitConverter.ToUInt32(frame, 2)*PMT).ToString());
						break;
					case (byte)Data_target.TDD:
						//待定，等待具体细节
						break;
					case (byte)Data_target.ANGLE_V:
						target.set_text(frame[1], BitConverter.ToSingle(frame, 2).ToString());
						break;
					case (byte)Data_target.ANGLE_L:
						target.set_text(frame[1], BitConverter.ToSingle(frame, 2).ToString());
						break;
					case (byte)Data_target.STATU:
						uint a = 1;
						if (BitConverter.ToUInt32(frame, 2) == a)
						{
							target.set_text(frame[1], "连接");
						}
						else
						{
							target.set_text(frame[1], "断线");
						}
						break;
					default:
						//帧结构出错、串口信息接收不全
						return false;
				}
				return true;
			}
			else return false;
		}

		
		//函数目的：根据对应的信息来源，生成发送数据帧
		//参数
		//data:所发送的数据帧
		//master：串口
		public bool Send(byte target,string data, SerialPort master)
		{
			Array.Clear(data_send, 0, 6);
			switch (target)
			{
				case (byte)Send_target.START:
					//data_send[0] = Convert.ToByte('1'); LPH
					data_send[0] = (byte)Data_dir.TO_MCU;
					data_send[1] = target;
					Buffer.BlockCopy(BitConverter.GetBytes((UInt32)1), 0, data_send, 2, 4);
					return SendData(data_send,master);
				case (byte)Send_target.RESET:
					//data_send[0] = Convert.ToByte('1'); LPH
					data_send[0] = (byte)Data_dir.TO_MCU;
					data_send[1] = target;
					Buffer.BlockCopy(BitConverter.GetBytes((UInt32)1), 0, data_send, 2, 4);
					return SendData(data_send, master);
				default:
					return false;
			}
		}

		//测试所有接收接口
		public void InterfaceTest(Form1 target, SerialPort master)
		{
			//byte s = (byte)'3'; LPH
			byte s = (byte)Data_dir.TO_PC;

			byte[] rate_r = new byte[6];
			byte[] rate_t = new byte[6];
			byte[] cn_r = new byte[6];
			byte[] cn_t = new byte[6];
			byte[] cn_ber = new byte[6];
			byte[] power = new byte[6];
			byte[] pmt = new byte[6];
			byte[] a_v = new byte[6];
			byte[] a_l = new byte[6];
			byte[] statu = new byte[6];
			cn_r[0]= cn_t[0]= pmt[0] = a_v[0]= a_l[0]=statu[0]= power[0] = cn_ber [0]= rate_t[0] = rate_r[0] = s;
			rate_r[1] = (byte)Data_target.RATE_RX;
			Buffer.BlockCopy(BitConverter.GetBytes((UInt32)1500), 0, rate_r, 2, 4);
			rate_t[1] = (byte)Data_target.RATE_TX;
			Buffer.BlockCopy(BitConverter.GetBytes((UInt32)1500), 0, rate_t, 2, 4);
			cn_r[1] = (byte)Data_target.CN_RX;
			Buffer.BlockCopy(BitConverter.GetBytes((UInt32)200000), 0, cn_r, 2, 4);
			cn_t[1] = (byte)Data_target.CN_TX;
			Buffer.BlockCopy(BitConverter.GetBytes((UInt32)200000), 0, cn_t, 2, 4);
			cn_ber[1] = (byte)Data_target.CN_BER;
			Buffer.BlockCopy(BitConverter.GetBytes((UInt32)20), 0, cn_ber, 2, 4);
			a_v[1] = (byte)Data_target.ANGLE_V;
			Buffer.BlockCopy(BitConverter.GetBytes((float)20.625F), 0, a_v, 2, 4);
			a_l[1] = (byte)Data_target.ANGLE_L;
			Buffer.BlockCopy(BitConverter.GetBytes((float)40.178F), 0, a_l, 2, 4);
			statu[1] = (byte)Data_target.STATU;
			Buffer.BlockCopy(BitConverter.GetBytes((UInt32)1), 0, statu, 2, 4);
			Analy(rate_r, target);
			Analy(rate_t, target);
			Analy(cn_r, target);
			Analy(cn_t, target);
			Analy(cn_ber, target);
			Analy(a_v, target);
			Analy(a_l, target);
			Analy(statu, target);
			SendData(rate_r, master);
			SendData(rate_t, master);
			SendData(cn_r, master);
			SendData(cn_t, master);
			SendData(cn_ber, master);
			SendData(a_v, master);
			SendData(a_l, master);
			SendData(statu, master);
		}

		//发送数据
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
