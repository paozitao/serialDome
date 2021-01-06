using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Windows.Forms;
using System.Data;
using System.Configuration;

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
		private bool isReceive = false;
		private uint cn_rs;
		private uint cn_rs_error = 0;
		private uint cn_error;
		private uint light_vol = 0;
		private int cn_light = 0;
		private float cur_light = 0;


		//每接收多少个接收光强电压帧平均一次
		const int NUM_TIME_LV = 2;
		const int NUM_TIME_PER_FRAME = 10000;
		DateTime time1;
		DateTime time2 = DateTime.Now;
		/*当前的时钟频率状态 0为0 1为6.25M 2为12.5M 3为25M 默认为0*/
		private int rate = 0;

		/*当前通信状态 0为断线、1为差、2较差、3一般、4良好、5通畅*/
		private int statu_com = 0;

		/*自动遍历启动*/
		private bool flag_auto = false;
		private bool isOOK = false;

		AutoChange autoChange;

		// 比较器阈值和衰减片电压的无符号整数数值转换到实际电压所乘以的系数，V=data*AD
		public const float AD = 0.796F;
		public const float AD_thres = 0.504F;
		// 控制PMT增益电压的系数
		public const float AD2 = 0.8F;

		private SerialPort master;

		
		
		public float GetAd2()
        {
			return AD2;
        }

		//验证帧头是否符合“3A-3Z”
		public bool Head_test(byte [] head)
		{
			if(head[0] != Convert.ToByte('3'))
			{
				return false;
			}
			else if (head[1]<65 || head[1]>90)
			{
				return false;
			}
			else
			{
				return true;
			}
		}

		const int dam_start = 1000;
		const int dam_stop = 2400;
		const int dam_interval = 2;
		//提取信息帧数据，并设置到响应的控件中
		//参数
		//data:接收的数据帧
		public bool Analy(byte[] frame,Form1 target)
		{
			Buffer.BlockCopy(frame, 0, f_head, 0, 2);
			if (Head_test(f_head))
			{
				string str;
				switch (frame[1])
				{
					case (byte)Data_target.RPS:
						target.set_text(frame[1],getRataTxData(frame));
 						break;
					case (byte)Data_target.THRESHOLD:
						target.set_text(frame[1],(BitConverter.ToUInt32(frame, 2)*AD_thres).ToString("f1")+"mV");
						break;
					case (byte)Data_target.CN_TX:
						target.set_text(frame[1], BitConverter.ToUInt32(frame, 2).ToString() + "帧/s");
						break;
					case (byte)Data_target.CN_RX:
						target.set_text(frame[1], BitConverter.ToUInt32(frame, 2).ToString() + "帧/s");
						break;
					case (byte)Data_target.CN_BYTE:
						cn_error = (BitConverter.ToUInt32(frame, 2) + cn_rs_error * 20);
	/*					autoChange.SetError(cn_error);*/
						target.set_text(frame[1], cn_error.ToString() + "B/s");
						break;
					/*此帧与误比特量同时发送，但早于误比特量，纠错rs帧说明误比特量大于8*/
					case (byte)Data_target.CN_BER:
						cn_rs = BitConverter.ToUInt16(frame, 2);
						cn_rs_error = BitConverter.ToUInt16(frame, 4);
						if (cn_rs>0)
						{
							float ber = (float)cn_rs_error / (float)cn_rs;
							target.set_text(frame[1], ber.ToString("0.#%")+","+cn_rs.ToString());
						}
                        else
                        {
							target.set_text(frame[1], "无业务数据");
						}
						break;
					case (byte)Data_target.OPTIC_V:
						cur_light = (float)BitConverter.ToUInt32(frame, 2)* AD/ 1000;
						light_vol += BitConverter.ToUInt32(frame, 2);
 /*                       测量接口频率，平均0.78s 暂定0.8s */
/*                        time1 = time2;
                        time2 = DateTime.Now;
                        TimeSpan ts = time2.Subtract(time1);
                        Console.WriteLine("每一帧相差秒数：{0}", ts.TotalSeconds);*/
                        cn_light++;
						if(cn_light == NUM_TIME_LV)
                        {
							cn_light = 0;
							target.set_text(frame[1], ((Double)light_vol/NUM_TIME_LV/NUM_TIME_PER_FRAME*AD/1000).ToString("F4") + "V");
							light_vol = 0;
                        }
						break;
					case (byte)Data_target.DAMPING:
						target.set_text(frame[1], (BitConverter.ToUInt32(frame, 2)*AD).ToString("f3")+"mV");
						break;
                    case (byte)Data_target.STATU:
						target.set_text(frame[1], getStatuData(frame));
						break;
					case (byte)Data_target.PMT:
						target.set_text(frame[1], (BitConverter.ToUInt16(frame, 2)*AD2).ToString("f0") + "," 
										+ (BitConverter.ToUInt16(frame, 4)*AD2).ToString("f0"));
						break;
					case (byte)Data_target.TEM:
						target.set_text(frame[1], frame[2].ToString() + ","
												+ frame[3].ToString() + ","
												+ frame[4].ToString() + ","
												+ frame[5].ToString());
						break;
					default:
						//帧结构出错、串口信息接收不全
						return false;
				}
				return true;
			}
			else return false;
		}

		// 提取光功率模式
		string getPowerData(byte frame)
        {
			switch(frame){
				case (byte)0:
					return "全部关闭";
				case (byte)1:
					return "散光";
				case (byte)2:
					return "汇聚光";
				case (byte)3:
					return "全部开启";
				default:
					return "全部关闭";
			}
        }

		// 提取RPS信号
		string getRataTxData(byte[] frame)
		{
			string data;
			switch (frame[2])
			{
				/*6.25MHz*/
				case (byte)2:
					data = "6.25";
					rate = 1;
					break;
				/*12.5MHz*/
				case (byte)3:
					data = "12.5";
					rate = 2;
					break;
				/*25MHz*/
				case (byte)1:
					data = "25";
					rate = 3;
					break;
				case (byte)0:
					data = "25";
					rate = 3;
					break;
				default:
					data = "数据帧出错";
					rate = 0;
					break;
			}
			data +=( "MHz," + getPowerData(frame[3])+",");
			
			switch (frame[4])
			{
				case (byte)0:
					data += "从机";
					break;
				case (byte)1:
					data += "主机";
					break;
				default:
					data += "主机";
					break;
			}
			return data;
		}
		private uint tdd_num;

        public SerialPort Master { get => master; set => master = value; }

        public uint GetTddNum()
        {
			return tdd_num;
        }
		//	获取一秒内接受到的TDD帧个数分析通信状态
		string getStatuData(byte[] frame)
		{
			uint tdd_num = BitConverter.ToUInt32(frame, 2);
            if (flag_auto)
            {
                if (autoChange.IsActive())
                {
					if (autoChange.dam_change)
					{
						autoChange.dam_change = false;
					}
					else
					{
/*						autoChange.SetTddNum(tdd_num);*/
					}
                }
                else
                {
					MessageBox.Show("发送失败，扫描结束，请确保串口通畅");
					flag_auto = false;
				}

            }
			this.tdd_num = tdd_num;
			/* OOK调制下主从时隙1：1下 根据tdd帧数量设置通信状态 */
            if (isOOK)
            {
				switch (rate)
				{
					//断线
					//6.25MHz时钟下
					case 1:
						{

							if (tdd_num == 0)
							{
								statu_com = 0;
								return "断线";
							}
							else if (tdd_num > 0 && tdd_num <= 50)
							{
								statu_com = 1;
								return "差";
							}
							else if (tdd_num > 50 && tdd_num <= 100)
							{
								statu_com = 2;
								return "较差";
							}
							else if (tdd_num > 100 && tdd_num <= 200)
							{
								statu_com = 3;
								return "一般";
							}
							else if (tdd_num > 200 && tdd_num < 250)
							{
								statu_com = 4;
								return "良好";
							}
							else
							{
								statu_com = 5;
								return "通畅";
							}
						}
					//12.5MHz时钟下
					case 2:
						{
							if (tdd_num == 0)
							{
								statu_com = 0;
								return "断线";
							}
							else if (tdd_num > 0 && tdd_num <= 100)
							{
								statu_com = 1;
								return "差";
							}
							else if (tdd_num > 100 && tdd_num <= 200)
							{
								statu_com = 2;
								return "较差";
							}
							else if (tdd_num > 200 && tdd_num <=400)
							{
								statu_com = 3;
								return "一般";
							}
							else if (tdd_num > 400 && tdd_num < 473)
							{
								statu_com = 4;
								return "良好";
							}
							else
							{
								statu_com = 5;
								return "通畅";
							}
						}
/*                         //25MHz时钟OOK 主从时隙1：1 
                    case 3:
                        {
                            if (tdd_num == 0)
                            {
                                statu_com = 0;
                                return "断线";
                            }
                            else if (tdd_num > 0 && tdd_num <= 300)
                            {
                                statu_com = 1;
                                return "差";
                            }
                            else if (tdd_num > 300 && tdd_num <= 500)
                            {
                                statu_com = 2;
                                return "较差";
                            }
                            else if (tdd_num > 500 && tdd_num <= 700)
                            {
                                statu_com = 3;
                                return "一般";
                            }
                            else if (tdd_num > 700 && tdd_num < 950)
                            {
                                statu_com = 4;
                                return "良好";
                            }
                            else
                            {
                                statu_com = 5;
                                return "通畅";
                            }*/
                             //25MHz时钟OOK调试下 时隙比5：1下
                    case 3:
                        {
                            if (tdd_num == 0)
                            {
                                statu_com = 0;
                                return "断线";
                            }
                            else if (tdd_num > 0 && tdd_num <= 1400)
                            {
                                statu_com = 1;
                                return "差";
                            }
                            else if (tdd_num > 1400 && tdd_num <= 1540)
                            {
                                statu_com = 2;
                                return "较差";
                            }
                            else if (tdd_num > 1540 && tdd_num <= 1560)
                            {
                                statu_com = 3;
                                return "一般";
                            }
                            else if (tdd_num > 1560 && tdd_num < 1564)
                            {
                                statu_com = 4;
                                return "良好";
                            }
                            else
                            {
                                statu_com = 5;
                                return "通畅";
                            }
                        }
					default:
						return "错误";

				}

			}
			/*PPM调制下主从时隙1：1下 根据tdd帧数量设置通信状态 */
			else
			{
				switch (rate)
				{
					//断线
					//6.25MHz时钟下
					case 1:
						{

							if (tdd_num == 0)
							{
								statu_com = 0;
								return "断线";
							}
							else if (tdd_num > 0 && tdd_num <= 30)
							{
								statu_com = 1;
								return "差";
							}
							else if (tdd_num > 30 && tdd_num <= 40)
							{
								statu_com = 2;
								return "较差";
							}
							else if (tdd_num > 40 && tdd_num <= 50)
							{
								statu_com = 3;
								return "一般";
							}
							else if (tdd_num > 50 && tdd_num < 55)
							{
								statu_com = 4;
								return "良好";
							}
							else
							{
								statu_com = 5;
								return "通畅";
							}
						}
					//12.5MHz时钟下
					case 2:
						{
							if (tdd_num == 0)
							{
								statu_com = 0;
								return "断线";
							}
							else if (tdd_num > 0 && tdd_num <= 40)
							{
								statu_com = 1;
								return "差";
							}
							else if (tdd_num > 40 && tdd_num <= 60)
							{
								statu_com = 2;
								return "较差";
							}
							else if (tdd_num > 60 && tdd_num <= 90)
							{
								statu_com = 3;
								return "一般";
							}
							else if (tdd_num > 90 && tdd_num < 112)
							{
								statu_com = 4;
								return "良好";
							}
							else
							{
								statu_com = 5;
								return "通畅";
							}
						}
					//25MHz时钟 PPM调制下
					case 3:
						{
							if (tdd_num == 0)
							{
								statu_com = 0;
								return "断线";
							}
							else if (tdd_num > 0 && tdd_num <= 50)
							{
								statu_com = 1;
								return "差";
							}
							else if (tdd_num > 50 && tdd_num <= 100)
							{
								statu_com = 2;
								return "较差";
							}
							else if (tdd_num > 100 && tdd_num <= 200)
							{
								statu_com = 3;
								return "一般";
							}
							else if (tdd_num > 200 && tdd_num <= 235)
							{
								statu_com = 4;
								return "良好";
							}
							else
							{
								statu_com = 5;
								return "通畅";
							}
						}
					default:
						return "错误";
				}
			}


			
		}



		public void AutoStart(int init,int interval, SerialPort master)
        {
			autoChange = new AutoChange(interval, init,master);
			flag_auto = true;
		}

		public void AutoStop()
        {
			
			flag_auto = false;

        }

		//函数目的：根据对应的信息来源，生成发送数据帧
		//参数
		//target：发送的内容标识
		//data: 所发送的数据
		//master：串口
		public bool Send(byte target,int data, SerialPort master)
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
				case (byte)Send_target.RATE_TX:
					data_send[0] = (byte)Data_dir.TO_FPGA;
					data_send[1] = target;
					switch (data)
                    {
						//6.25MHz
						case 0:
							data = 2;
							break;
						//12.5MHz
						case 1:
							data = 3;
							break;
						//25MHz
						case 2:
							data = 1;
							break;
                    }
					Buffer.BlockCopy(BitConverter.GetBytes((UInt32)data), 0, data_send, 2, 4);
					return SendData(data_send, master);
				case (byte)Send_target.POWER:
					data_send[0] = (byte)Data_dir.TO_FPGA;
					data_send[1] = target;
					Buffer.BlockCopy(BitConverter.GetBytes((UInt32)data), 0, data_send, 2, 4);
					return SendData(data_send, master);
				case (byte)Send_target.THRESHOLD:
					data_send[0] = (byte)Data_dir.TO_MCU;
					data_send[1] = target;
					Buffer.BlockCopy(BitConverter.GetBytes((UInt32)(data/AD_thres)), 0, data_send, 2, 4);
					return SendData(data_send, master);
				case (byte)Send_target.PMT:
					data_send[0] = (byte)Data_dir.TO_MCU;
					data_send[1] = target;
					Buffer.BlockCopy(BitConverter.GetBytes((UInt32)(data / AD2)), 0, data_send, 2, 4);
					return SendData(data_send, master);
				case (byte)Send_target.PMT_SAVE:
					data_send[0] = (byte)Data_dir.TO_MCU;
					data_send[1] = target;
					Buffer.BlockCopy(BitConverter.GetBytes((UInt32)(data / AD2)), 0, data_send, 2, 4);
					return SendData(data_send, master);
				case (byte)Send_target.DAMPING:
					data_send[0] = (byte)Data_dir.TO_MCU;
					data_send[1] = target;
					Buffer.BlockCopy(BitConverter.GetBytes((UInt32)(data/AD)), 0, data_send, 2, 4);
					return SendData(data_send, master);
				case (byte)Send_target.CH_MS:
					data_send[0] = (byte)Data_dir.TO_FPGA;
					data_send[1] = target;
					Buffer.BlockCopy(BitConverter.GetBytes((UInt32)(data)), 0, data_send, 2, 4);
					return SendData(data_send, master);
				default:
					return false;
			}
		}


		public void AutoChange(SerialPort master)
        {

        }

		public void AutoSetThres(SerialPort master)
        {

        }
		//返回通信状态
		public int getComStatu()
        {
			return statu_com;
        }

		public bool GetFlagAuto()
		{
			return flag_auto;

		}

		public void SetFlagAuto(bool value)
		{
			flag_auto = value;
		}

		public void SetModu(bool isOOK)
        {
			this.isOOK = isOOK;
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
