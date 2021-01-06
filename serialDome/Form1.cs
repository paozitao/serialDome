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
using ClosedXML.Excel;

// 数据帧发送目标
enum Data_dir : byte
{
	TO_FPGA = (byte)'1',
	TO_MCU = (byte)'2',
	TO_PC = (byte)'3'
}

//接收数据帧的帧头的数据含义
enum Data_target : byte
{
	RPS = (byte)'I',		//发送端电信号时钟速率Rate、激光器功率Power、主从状态Statu_ms三合一帧
	THRESHOLD = (byte)'K',	//信号判断的比较器电压阈值
	CN_TX = (byte)'A',		//发送的以太网帧总量
	CN_RX = (byte)'H',		//接收的以太网帧总量
	CN_BYTE = (byte)'N',	//每秒误码数据量
	CN_BER  = (byte)'R',	//RS纠错失败比率
	DAMPING = (byte)'L',    //衰减片电压
	PMT = (byte)'Q',		//PMT灵敏度
	TEM = (byte)'T',		// 温湿度
	STATU = (byte)'M',		//通信状态
	OPTIC_V = (byte)'U'		//接收光强电压
}

//发送数据帧的数据含义
enum Send_target: byte
{
	START = (byte)'A',		//提示MCU发送数据（无用）
	RESET = (byte)'B',		//复位FPGA
	RATE_TX = (byte)'V',	//发送端时钟频率设置
	DAMPING = (byte)'D',    //衰减片控制电压
	PMT = (byte)'G',        // 调节PMT灵敏度
	PMT_SAVE = (byte)'W',   // 保存当前设置的PMT灵敏度到DACRom中
	THRESHOLD = (byte)'E',	//比较器阈值设置
	POWER = (byte)'P',		//激光器功率设置
	CH_MS = (byte)'S'		//主从机切换
}

/*数据指示*/
enum DataSetIndex : int
{
	zero,time,pmt,light_power,statu,tdd_num,rx_power,txRate,ber_cn,damping,thres,cn_rx
}
namespace serialDome
{
	public partial class Form1 : MetroForm
	{
		//串口接口功能类
		Info_interface info_interface = new Info_interface();
		
		private bool isOpen = false;

		private double[] yAxis = new double[20];
		//缓存区最大区域：
		const int MAX = 100000;
		//串口接收缓存区
		private byte[] r_buf = new byte[MAX];

		//未经处理的缓存区的byte数
		private int cn_byte = 0;

		//分析数据帧的参数
		byte[] frame = new byte[6];
		byte[] head = new byte[2];
		int start = 0;

		//保存当前状态和上一状态的比较器阈值和遮光片强度,0、1存放比较器阈值
		int[] DataBuf= {0,0,1000,1000 };

		//当前主从状态(主机1，从机0)，初始默认为主机1
		int flag_ms = 1;
		/*当前的时钟频率。0为0 1为6.25M 2为12.5M 3为25M 默认为0*/

		private System.Threading.Timer timer;

		bool auto_flag = false;

		/*		数据保存的文件路径 */
		string fp= @"C:\File\Data\TestData\Data.xlsx";

		XLWorkbook g_wb;

		public Form1()
		{
			InitializeComponent();
			System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;
		}

		//页面加载初始化
		private void Form1_Load(object sender, EventArgs e)
		{

<<<<<<< HEAD
			int a = Convert.ToInt32(thres.Text.ToString().Split('m')[0]);
			Console.WriteLine(a);
			//导入系统串口
			foreach (string vPortName in SerialPort.GetPortNames())
			{
				sw_com.Items.Add(vPortName);
			}
			info_interface.SetModu(isOOK.Checked);
        }
=======

			chart1.Series[0].Points.AddY(0);

			//从机和设置panel的位置初始化，默认不可见
			pn_set.Location = new System.Drawing.Point(105, 75);
			pn_slave.Location = new System.Drawing.Point(105, 75);

		}
>>>>>>> ecce09b9212c6822719867dd9c3155ebb2e9b5ee



		//接受串口信号模块
		private void master_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
		{
            //textBox_uart_msg.Text += "get in master_DataReceived";
            //等待100ms，等待各个数据帧发送完毕
            //info_interface.InterfaceTest(this, master);
			Thread.Sleep(100);
			//如果在等待中，串口断开，则返回。
            if (!master.IsOpen)
            {
				CloseUart();
				MessageBox.Show("串口已断开");
				return;
            }
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
				while (!info_interface.Head_test(head))
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

                string str = System.Text.Encoding.Default.GetString(frame);
                //textBox_uart_msg.Text = str;

                //当出现剩余数据时，保存到缓存区中
                if ((n + cn_byte - start) % 6 != 0  && (n + cn_byte - start)>0)
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
<<<<<<< HEAD
                    master.PortName = sw_com.Text;
=======
					master.PortName = sw_com.Text;
>>>>>>> ecce09b9212c6822719867dd9c3155ebb2e9b5ee
					master.Open();
					//清除接收缓存区
					master.DiscardInBuffer();
					swtich.Text = "关闭串口";
					swtich.Image = Properties.Resources.on;
					sw_com.Enabled = false;
                    SendThres(2000);
                    //textBox_uart_msg.Text += "open";
                    //master.Write("test");
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
				CloseUart();
			}

		}

		private void CloseUart()
        {
			master.Close();
			swtich.Image = Properties.Resources.off;
			swtich.Text = "打开串口";
			sw_com.Enabled = true;
			isOpen = false;
		}

		//设置对应文本框的数据
		public void set_text(byte target, string str)
		{
			switch (target)
			{
				case (byte)Data_target.RPS:
					String[] data_ber1 = str.Split(',');
					txRate.Text	  = data_ber1[0];
					power.Text	  = data_ber1[1];
					statu_ms.Text = data_ber1[2];
					if (data_ber1[2] == "主机")
					{
						flag_ms = 1;
					}
					else
					{
						flag_ms = 0;
					}
					break;
				case (byte)Data_target.THRESHOLD:
					thres.Text = str;
					break;
				case (byte)Data_target.CN_TX:
					cn_tx.Text = str;
					break;
				case (byte)Data_target.CN_RX:
					cn_rx.Text = str;
					break;
				case (byte)Data_target.CN_BYTE:
					ber_cn.Text = str;
					
					cn_error1 = cn_error2;

					try
					{
						cn_error2 = Convert.ToInt32(str.Split('B').First());
					}
                    catch (Exception)
                    {
						
                    }
					break;
				case (byte)Data_target.CN_BER:
					ber.Text = str.Split(',').First();
					if(str[0] == '无')
                    {
						error_flag = false;
                    }
                    else
                    {
						error_flag = true;
						cn_rs = Convert.ToInt32(str.Split(',').Last());
                    }
					break;
				case (byte)Data_target.DAMPING:
					damping.Text = str;
					break;
				case (byte)Data_target.OPTIC_V:
					rx_power.Text = str;
					break;
				case (byte)Data_target.STATU:
					tdd_num.Text = info_interface.GetTddNum().ToString();
					cn_tdd1 = cn_tdd2;
					cn_tdd2 = (int)info_interface.GetTddNum();
					statu.Text = str;
					if (info_interface.getComStatu() <= 1) statu.BackColor = Color.FromArgb(255, 0, 0);
					else if (info_interface.getComStatu() == 2) statu.BackColor = Color.FromArgb(204, 204,0);
					else if (info_interface.getComStatu() < 4 ) statu.BackColor = Color.FromArgb(102,204,102);
					else statu.BackColor = Color.FromArgb(102, 255, 0);
					break;
				case (byte)Data_target.PMT:
					String[] data_ber2 = str.Split(',');
					pmt.Text = data_ber2[0] + "mV";
					pmt_init.Text = data_ber2[1] + "mV";
					break;
				case (byte)Data_target.TEM:
					String[] data_ber3 = str.Split(',');
					rx_tem.Text = data_ber3[0] + "℃";
					rx_hum.Text = data_ber3[1] + "%";
					tx_tem.Text = data_ber3[2] + "℃";
					tx_hum.Text = data_ber3[3] + "%";
					break;

				default:
					//帧结构出错、串口信息接收不全
					break;
			}
		}

		//发送软复位信号
		private void reset_Click(object sender, EventArgs e)
		{
			Send((byte)Send_target.RESET,1);
		}

		private void ch_ms_Click(object sender, EventArgs e)
		{
            if (flag_ms == 1)
            {
				Send((byte)Send_target.CH_MS, 0);//当状态为1，切换为0
			}
            else
            {
				Send((byte)Send_target.CH_MS, 1);//当状态为0，切换为1
			}
			
		}
		//向MCU发送开始信号，提示发送信息
		private void Send_start()
		{
			Send((byte)Send_target.START, 1);
		}



		//设置发送电信号时钟频率
		private void TxSet_Click(object sender, EventArgs e)
		{
			if(txSetValue.SelectedIndex < 0)
            {
				MessageBox.Show("未选择速率", "错误");
			}
            else
            {
				Send((byte)Send_target.RATE_TX, txSetValue.SelectedIndex);
				//.Text = txSetValue.SelectedIndex.ToString();
			}

		}

		//设置光功率
		private void PWSet_Click(object sender, EventArgs e)
		{
			if (txSetValue.SelectedIndex < 0)
			{
				MessageBox.Show("未选择功率", "错误");
			}
			else
			{
				Send((byte)Send_target.POWER, pwSetValue.SelectedIndex);
			}

		}

		//设置PMT增益
		private void PmtSet_Click(object sender, EventArgs e)
		{
			Send((byte)Send_target.PMT, (int)((float)PmtSetValue.Value));
		}

		// 设置默认PMT增益
		private void PmtSave_Click(object sender, EventArgs e)
		{
			Send((byte)Send_target.PMT_SAVE, (int)((float)PmtSetValue.Value));
		}

		//设置比较器阈值
		private void ThresSet_Click(object sender, EventArgs e)
		{
			if(Send((byte)Send_target.THRESHOLD, (int)thresSetValue.Value))
            {
				DataBuf[0] = DataBuf[1];
				DataBuf[1] = (int)thresSetValue.Value;
            }

		}

		// 返回为上一个状态的比较器阈值
		private void ThresRetn_Click(object sender, EventArgs e)
		{
			thresSetValue.Value = DataBuf[0];
		}

		// 设置遮光片电压
		private void DampingSet_Click(object sender, EventArgs e)
		{
			if (Send((byte)Send_target.DAMPING, (int)damSetValue.Value))
			{
				DataBuf[2] = DataBuf[3];
				DataBuf[3] = (int)damSetValue.Value;
			}
		}
		
		//返回为上一个状态的遮光片电压
		private void PmtRetn_Click(object sender, EventArgs e)
		{
			damSetValue.Value = DataBuf[2];
		}
		//发送状态判断
		bool Send(byte target, int data)
        {
			if (master.IsOpen)
			{
				info_interface.Send(target, data, master);
				return true;
            }
            else
            {
				MessageBox.Show("串口未打开，发送失败，请打开串口", "错误");
				return false;
			}
		}

		//当键入回车键直接发送数据帧，若其中的值不在范围，自动发送设置的最大值或者最小值
		private void damSetValue_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				if (Send((byte)Send_target.DAMPING, (int)damSetValue.Value))
				{
					DataBuf[2] = DataBuf[3];
					DataBuf[3] = (int)damSetValue.Value;
				}
			}
		}

		//当键入回车键直接设置比较器阈值
		private void thresSetValue_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				if (Send((byte)Send_target.THRESHOLD, (int)thresSetValue.Value))
				{
					DataBuf[0] = DataBuf[1];
					DataBuf[1] = (int)thresSetValue.Value;
				}
			}
		}

		//当键入回车键直接设置pmt增益
		private void PmtSetValue_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				Send((byte)Send_target.PMT, (int)PmtSetValue.Value);
			}
		}

		//当键入光功率直接保存当前数据
		private void LightPower_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				if (!master.IsOpen)
				{
					MessageBox.Show("串口未连接，数据无效", "Error");
					return;
				}
				try
				{
					g_wb = new XLWorkbook(fp);
				}
				catch (System.IO.FileNotFoundException)
				{
					MessageBox.Show("未找到此文件，其确保当前路径正确", "错误");
					return;
				}
				catch (System.IO.IOException)
				{
					MessageBox.Show("此文件已被占用，请关闭后再保存数据", "错误");
					return;
				}
				IXLWorksheet ws = g_wb.Worksheets.First();
				if (ws.CellsUsed().Count() == 0)
				{
					ws.Name = "调试数据";
					AddColName(ws);
				}

				ExcelWriteData(ws);

				g_wb.Save();
			}
		}


		//自动遍历遮光片电压，找寻最佳电压使得TDD帧最大

		/*	数据保存功能	*/

		private void button1_Click(object sender, EventArgs e)
		{
			OpenFileDialog file = new OpenFileDialog();
			if (file.ShowDialog() == DialogResult.OK)
			{
				fp =  file.FileName;
				filepath.Text = "保存到：" + fp.ToString().Trim();
			}
		}

		private string SelectPath() //弹出一个选择目录的对话框
		{
			FolderBrowserDialog path = new FolderBrowserDialog();
			path.ShowDialog();
			return path.SelectedPath;
		}


		private void button1_Click_1(object sender, EventArgs e)
		{
			OpenFileDialog file = new OpenFileDialog();
			if (file.ShowDialog() == DialogResult.OK)
			{
                if (file.FileName.Split('.').Last() != "xlsx")
                {
					MessageBox.Show("请选择Excel文件","错误！");
                }
                else
                {
					fp = file.FileName;
					filepath.Text = "保存到：" + fp.ToString().Trim();
				}

			}
		}

		private void save_data_Click(object sender, EventArgs e)
		{
            if (!master.IsOpen)
            {
				MessageBox.Show("串口未连接，数据无效","Error");
				return ;
            }
			try
            {
				g_wb = new XLWorkbook(fp);
			}
            catch (System.IO.FileNotFoundException)
            {
				MessageBox.Show("未找到此文件，其确保当前路径正确", "错误");
				return;
            }
            catch (System.IO.IOException)
            {
				MessageBox.Show("此文件已被占用，请关闭后再保存数据", "错误");
				return;
			}

			IXLWorksheet ws = g_wb.Worksheets.First();
			if (ws.CellsUsed().Count() == 0)
			{
				ws.Name = "调试数据";
				AddColName(ws);
			}

			ExcelWriteData(ws);

			g_wb.Save();

		}

		

		private void AddColName(IXLWorksheet ws)
        {
			ws.Cell(1, (int)DataSetIndex.time).Value = "调试时间";
			ws.Cell(1, (int)DataSetIndex.pmt).Value = "增益电压";
			ws.Cell(1, (int)DataSetIndex.thres).Value = "比较器阈值(mV)";
			ws.Cell(1, (int)DataSetIndex.damping).Value = "衰减片电压(mV)";
			ws.Cell(1, (int)DataSetIndex.txRate).Value = "时钟速率";
			ws.Cell(1, (int)DataSetIndex.ber_cn).Value = "误比特率(B/s)";
			ws.Cell(1, (int)DataSetIndex.statu).Value = "通信状态";
			ws.Cell(1, (int)DataSetIndex.rx_power).Value = "接收端光强(V)";
			ws.Cell(1, (int)DataSetIndex.cn_rx).Value = "接收帧数量(帧/s)";
			ws.Cell(1, (int)DataSetIndex.light_power).Value = "当前光功率计示数（pw）";
			ws.Cell(1, (int)DataSetIndex.tdd_num).Value = "TDD帧头数量";
			ws.Columns().Width = 18;
		}

		private void ExcelWriteData(IXLWorksheet ws)
        {
			int row_start = ws.RowsUsed().Count();
			ws.Cell(row_start + 1, (int)DataSetIndex.time).Value = DateTime.Now.ToString();
			ws.Cell(row_start + 1, (int)DataSetIndex.pmt).Value = pmt.Text.ToString().Split('m')[0];
			ws.Cell(row_start + 1, (int)DataSetIndex.thres).Value =  thres.Text.ToString().Split('m')[0];
			ws.Cell(row_start + 1, (int)DataSetIndex.damping).Value = damping.Text.Split('m')[0];
			ws.Cell(row_start + 1, (int)DataSetIndex.txRate).Value = txRate.Text;
			ws.Cell(row_start + 1, (int)DataSetIndex.ber_cn).Value = ber_cn.Text.Split('B')[0];
			ws.Cell(row_start + 1, (int)DataSetIndex.statu).Value = statu.Text;
			ws.Cell(row_start + 1, (int)DataSetIndex.rx_power).Value = rx_power.Text.Split('V')[0]; 
			ws.Cell(row_start + 1, (int)DataSetIndex.cn_rx).Value = cn_rx.Text.Split('帧')[0];
			ws.Cell(row_start + 1, (int)DataSetIndex.light_power).Value = LightPower.Text;
			ws.Cell(row_start + 1, (int)DataSetIndex.tdd_num).Value = tdd_num.Text;
			try
			{
				g_wb.Save();
			}
            catch (Exception)
            {

            }
		}

		/*自动定时保存数据按钮*/
		private void auto_save_Click(object sender, EventArgs e)
		{

			if (auto_flag)
			{
				timer.Dispose();
				auto_flag = false;
				auto_save.Text = "开始自动保存数据";
				auto_save.Image = Properties.Resources.off;
				return;
			}
			else
			{
				if (save_interval.Value == 0)
				{
					MessageBox.Show("定时间隔不能为0");
					return;
				}
				if (!master.IsOpen)
				{
					MessageBox.Show("串口未打开");
					return;
				}
				try
				{
					g_wb = new XLWorkbook(fp);
				}
				catch (System.IO.FileNotFoundException)
				{
					MessageBox.Show("未找到此文件，其确保当前路径正确", "错误");
					return;
				}
				catch (System.IO.IOException)
				{
					MessageBox.Show("此文件已被占用，请关闭后再保存数据", "错误");
					return;
				}

				try
				{
					auto_flag = true;
					auto_save.Text = "自动保存中，停止保存";
					auto_save.Image = Properties.Resources.on;
                    if (DefaultTableName)
                    {
						g_wb.AddWorksheet(DateTime.Now.ToString("MMdd-HHmm") + "自动保存数据表");
					}
                    else
                    {
						g_wb.AddWorksheet(DataTableName.Text);
					}
					DefaultTableName = true;
				}
                catch (Exception)
                {
					MessageBox.Show("请等待,稍后再进行保存");
					return;
                }
				IXLWorksheet ws = g_wb.Worksheets.Last();
				AddColName(ws);
				ws.Columns().Width = 20;
                timer = new System.Threading.Timer(new TimerCallback(TimerStart), null, 0, (int)save_interval.Value);
                /*timer = new System.Threading.Timer(new TimerCallback(TimerStart), null, 0, 4200);
                timer2 = new System.Threading.Timer(new TimerCallback(AutoSendDamStart), null, 0, 4200);
                dam_t = dam_start;*/
            }

		}

		/*定时保存数据到Excel函数*/
		void TimerStart(object sender)
        {
			IXLWorksheet ws = g_wb.Worksheets.Last();
			ExcelWriteData(ws);
		}

		/*
		 *		通过控制比较器阈值自动调通链路
		 */
		bool autoch_thres_flag = false;
		uint thres_t;
		private System.Threading.Timer timer_thres;

		int cn_rs;
		int cn_error1;
		int cn_error2=0;
		int cn_tdd1;
		int cn_tdd2 = 0;

		/*是否有业务*/
		bool error_flag = false;
		private void autoch_thres_Click(object sender, EventArgs e)
		{
            if (!autoch_thres_flag)
            {
				if (dam_interval.Value == 0)
				{
					MessageBox.Show("精度不能为0");
					return;
				}
				if (!master.IsOpen)
				{
					MessageBox.Show("串口未打开");
					return;
				}
				timer_thres = new System.Threading.Timer(new TimerCallback(AutoSendThresStart), null, 0, (int)dam_thres_interval.Value);
				dam_t = (float)dam_init.Value;
				pl_autodam.Enabled = false;
				autoch_thres_flag = true;
				autoch_thres.Text = "比较器停止遍历";
				autoch_thres.Image = Properties.Resources.on;

			}
            else
            {
				timer_thres.Dispose();
				pl_autodam.Enabled = true;
				autoch_thres_flag = false;
				autoch_thres.Text = "比较器开始遍历";
				autoch_thres.Image = Properties.Resources.off;
			}

		}


		void AutoSendThresStart(object sender)
		{
			SendThres(dam_t);
			dam_t -= (float)dam_interval.Value;
			if (dam_t < (float)dam_end.Value)
			{
				timer_thres.Dispose();

				autoch_thres_flag = false;
				autoch_thres.Text = "比较器开始遍历";
				autoch_thres.Image = Properties.Resources.off;
				pl_autodam.Enabled = true;
				MessageBox.Show("遍历已完成", "提示");
				timer_thres.Dispose();
			}

		}

		bool LinkIsGreat()
		{
			/*tdd帧数作为第一判决条件*/
			if (LinkIsGreatByTdd())
			{
				/*存在业务数据时，通过误比特量判断链路，否则根据tdd帧*/
				if (error_flag)
				{
					if (cn_error2 < 150) return true;
					else return false;
				}
				else return true;
			}
			else return false;
		}


		bool LinkIsGreatByTdd()
		{
			if (info_interface.getComStatu() < 5) return false;
			else return true;
		}

		/*定时发送衰减片电压 */
		private System.Threading.Timer timer_dam;
		float dam_t;
		bool auto_chdam_flag = false;
		private void autoch_dam_Click(object sender, EventArgs e)
		{
			if (auto_chdam_flag)
			{
				timer_dam.Dispose();
				auto_chdam_flag = false;
				autoch_dam.Text = "衰减片开始遍历";
				autoch_dam.Image = Properties.Resources.off;
				pl_autodam.Enabled = true;
				return;
			}
			else
			{
				if (dam_interval.Value == 0)
				{
					MessageBox.Show("定时间隔不能为0");
					return;
				}
				if (!master.IsOpen)
				{
					MessageBox.Show("串口未打开");
					return;
				}

				auto_chdam_flag = true;
				autoch_dam.Text = "衰减片停止遍历";
				autoch_dam.Image = Properties.Resources.on;
				timer_dam = new System.Threading.Timer(new TimerCallback(AutoSendDamStart), null, 0, (int)dam_thres_interval.Value);
				dam_t = (float)dam_init.Value;
				pl_autodam.Enabled = false;
			}
		}

		void AutoSendDamStart(object sender)
        {
			SendDam(dam_t);
			dam_t -= (float)dam_interval.Value;
            if (dam_t < (float)dam_end.Value)
            {
				timer_dam.Dispose();
				auto_chdam_flag = false;
				autoch_dam.Text = "衰减片开始遍历";
				autoch_dam.Image = Properties.Resources.off;
				pl_autodam.Enabled = true;
				MessageBox.Show("遍历已完成", "提示");
            }

		}
		//无逻辑代码
		void SendDam(float data)
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
		void SendThres(float data)
		{
			byte[] data_send = new byte[6];
			data_send[0] = (byte)Data_dir.TO_MCU;
			data_send[1] = (byte)Send_target.THRESHOLD;
			Buffer.BlockCopy(BitConverter.GetBytes((UInt32)(data / 0.504)), 0, data_send, 2, 4);
			if (master.IsOpen)
			{
				master.Write(data_send, 0, 6);
			}
			else
			{
				MessageBox.Show("串口未打开");
			}
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

<<<<<<< HEAD
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void confm_rate_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }

        private void gb1_Enter(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void thresSetValue_ValueChanged(object sender, EventArgs e)
        {

        }

        private void groupBox7_Enter(object sender, EventArgs e)
        {

        }

        private void sw_com_Click(object sender, EventArgs e)
        {
			sw_com.Items.Clear();
=======
        private void sw_com_Click(object sender, EventArgs e)
        {
			sw_com.Items.Clear();
			//导入系统串口
>>>>>>> ecce09b9212c6822719867dd9c3155ebb2e9b5ee
			foreach (string vPortName in SerialPort.GetPortNames())
			{
				sw_com.Items.Add(vPortName);
			}
		}
<<<<<<< HEAD

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void chart_tdd_num_Click(object sender, EventArgs e)
        {

        }

        private void txSetValue_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void damping_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void filepath_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click_1(object sender, EventArgs e)
        {

        }

        private void label18_Click_1(object sender, EventArgs e)
        {

        }

        private void PmtSetValue_ValueChanged(object sender, EventArgs e)
        {

        }

        private void LightPower_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void pn_master_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void statu_ms_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void label37_Click(object sender, EventArgs e)
        {

        }
		private bool DefaultTableName = true;

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {
			DefaultTableName = false;
		}

        private void isOOK_EnabledChanged(object sender, EventArgs e)
        {
			info_interface.SetModu(isOOK.Checked);
		}

        private void isPPM_Click(object sender, EventArgs e)
        {
			info_interface.SetModu(isOOK.Checked);
		}

        private void isOOK_MouseClick(object sender, MouseEventArgs e)
        {
			info_interface.SetModu(isOOK.Checked);
		}
=======
>>>>>>> ecce09b9212c6822719867dd9c3155ebb2e9b5ee
    }
}
