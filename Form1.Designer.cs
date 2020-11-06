namespace serialDome
{
	partial class Form1
	{
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		/// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows 窗体设计器生成的代码

		/// <summary>
		/// 设计器支持所需的方法 - 不要修改
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.master = new System.IO.Ports.SerialPort(this.components);
            this.sw_com = new System.Windows.Forms.ComboBox();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.swtich = new System.Windows.Forms.Button();
            this.pn_master = new System.Windows.Forms.Panel();
            this.reset = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.statu = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ber_cn = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ber = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pmt = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.power = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cn_rx = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cn_tx = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.gb1 = new System.Windows.Forms.GroupBox();
            this.rxRate = new System.Windows.Forms.Label();
            this.txRate = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.button7 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.metroPanel1.SuspendLayout();
            this.pn_master.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gb1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            this.SuspendLayout();
            // 
            // master
            // 
            this.master.BaudRate = 115200;
            this.master.RtsEnable = true;
            this.master.StopBits = System.IO.Ports.StopBits.Two;
            this.master.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.master_DataReceived);
            // 
            // sw_com
            // 
            this.sw_com.BackColor = System.Drawing.Color.White;
            this.sw_com.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sw_com.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sw_com.FormattingEnabled = true;
            this.sw_com.Location = new System.Drawing.Point(114, 7);
            this.sw_com.Margin = new System.Windows.Forms.Padding(2);
            this.sw_com.Name = "sw_com";
            this.sw_com.Size = new System.Drawing.Size(101, 28);
            this.sw_com.TabIndex = 0;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.sw_com);
            this.metroPanel1.Controls.Add(this.label2);
            this.metroPanel1.Controls.Add(this.swtich);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(11, 20);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(369, 46);
            this.metroPanel1.TabIndex = 11;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(18, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "串口选择：";
            // 
            // swtich
            // 
            this.swtich.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.swtich.BackColor = System.Drawing.Color.White;
            this.swtich.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.swtich.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.swtich.FlatAppearance.BorderSize = 0;
            this.swtich.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.swtich.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.swtich.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.swtich.Image = global::serialDome.Properties.Resources.off;
            this.swtich.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.swtich.Location = new System.Drawing.Point(243, 2);
            this.swtich.Margin = new System.Windows.Forms.Padding(0);
            this.swtich.Name = "swtich";
            this.swtich.Size = new System.Drawing.Size(114, 39);
            this.swtich.TabIndex = 6;
            this.swtich.Text = "打开串口";
            this.swtich.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.swtich.UseVisualStyleBackColor = false;
            this.swtich.Click += new System.EventHandler(this.switch_Click);
            // 
            // pn_master
            // 
            this.pn_master.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_master.Controls.Add(this.panel1);
            this.pn_master.Controls.Add(this.button2);
            this.pn_master.Controls.Add(this.reset);
            this.pn_master.Controls.Add(this.panel4);
            this.pn_master.Controls.Add(this.groupBox2);
            this.pn_master.Controls.Add(this.groupBox3);
            this.pn_master.Controls.Add(this.groupBox1);
            this.pn_master.Controls.Add(this.gb1);
            this.pn_master.Controls.Add(this.label26);
            this.pn_master.Location = new System.Drawing.Point(8, 75);
            this.pn_master.Margin = new System.Windows.Forms.Padding(2);
            this.pn_master.Name = "pn_master";
            this.pn_master.Size = new System.Drawing.Size(594, 409);
            this.pn_master.TabIndex = 13;
            // 
            // reset
            // 
            this.reset.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.reset.FlatAppearance.BorderSize = 0;
            this.reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reset.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.reset.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.reset.Location = new System.Drawing.Point(306, 9);
            this.reset.Margin = new System.Windows.Forms.Padding(2);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(85, 30);
            this.reset.TabIndex = 10;
            this.reset.Text = "复位";
            this.reset.UseVisualStyleBackColor = false;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.statu);
            this.panel4.Controls.Add(this.label16);
            this.panel4.Location = new System.Drawing.Point(165, 8);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(123, 35);
            this.panel4.TabIndex = 6;
            // 
            // statu
            // 
            this.statu.BackColor = System.Drawing.SystemColors.Control;
            this.statu.Font = new System.Drawing.Font("微软雅黑 Light", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.statu.Location = new System.Drawing.Point(78, 6);
            this.statu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.statu.Name = "statu";
            this.statu.Size = new System.Drawing.Size(44, 18);
            this.statu.TabIndex = 1;
            this.statu.Text = "断线";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label16.Location = new System.Drawing.Point(2, 5);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(84, 19);
            this.label16.TabIndex = 0;
            this.label16.Text = "通信状态：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ber_cn);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.ber);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(28, 158);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox2.Size = new System.Drawing.Size(224, 99);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "信道误码/S";
            // 
            // ber_cn
            // 
            this.ber_cn.BackColor = System.Drawing.Color.White;
            this.ber_cn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ber_cn.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ber_cn.Location = new System.Drawing.Point(111, 66);
            this.ber_cn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ber_cn.Name = "ber_cn";
            this.ber_cn.Size = new System.Drawing.Size(105, 27);
            this.ber_cn.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(4, 66);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 26);
            this.label9.TabIndex = 2;
            this.label9.Text = "误码数据量：";
            // 
            // ber
            // 
            this.ber.BackColor = System.Drawing.Color.White;
            this.ber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ber.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ber.Location = new System.Drawing.Point(111, 30);
            this.ber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ber.Name = "ber";
            this.ber.Size = new System.Drawing.Size(105, 27);
            this.ber.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(4, 30);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 26);
            this.label11.TabIndex = 0;
            this.label11.Text = "误码率：";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pmt);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.power);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox3.Location = new System.Drawing.Point(321, 158);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox3.Size = new System.Drawing.Size(224, 99);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "信道光信号";
            // 
            // pmt
            // 
            this.pmt.BackColor = System.Drawing.Color.White;
            this.pmt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pmt.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pmt.Location = new System.Drawing.Point(111, 65);
            this.pmt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pmt.Name = "pmt";
            this.pmt.Size = new System.Drawing.Size(108, 27);
            this.pmt.TabIndex = 3;
            this.pmt.Text = "...mV";
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(4, 66);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(102, 26);
            this.label13.TabIndex = 2;
            this.label13.Text = "PMT灵敏度：";
            // 
            // power
            // 
            this.power.BackColor = System.Drawing.Color.White;
            this.power.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.power.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.power.Location = new System.Drawing.Point(111, 30);
            this.power.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.power.Name = "power";
            this.power.Size = new System.Drawing.Size(108, 27);
            this.power.TabIndex = 1;
            this.power.Text = "...挡";
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label15.Location = new System.Drawing.Point(4, 30);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(102, 26);
            this.label15.TabIndex = 0;
            this.label15.Text = "光功率强度：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cn_rx);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cn_tx);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(28, 54);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(224, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "数据吞吐量/S";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cn_rx
            // 
            this.cn_rx.BackColor = System.Drawing.Color.White;
            this.cn_rx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cn_rx.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cn_rx.Location = new System.Drawing.Point(112, 65);
            this.cn_rx.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cn_rx.Name = "cn_rx";
            this.cn_rx.Size = new System.Drawing.Size(105, 27);
            this.cn_rx.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(4, 66);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "接收总量：";
            // 
            // cn_tx
            // 
            this.cn_tx.BackColor = System.Drawing.Color.White;
            this.cn_tx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cn_tx.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cn_tx.Location = new System.Drawing.Point(111, 30);
            this.cn_tx.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cn_tx.Name = "cn_tx";
            this.cn_tx.Size = new System.Drawing.Size(105, 27);
            this.cn_tx.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(4, 30);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "发送总量：";
            // 
            // gb1
            // 
            this.gb1.Controls.Add(this.label6);
            this.gb1.Controls.Add(this.label3);
            this.gb1.Controls.Add(this.rxRate);
            this.gb1.Controls.Add(this.txRate);
            this.gb1.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gb1.Location = new System.Drawing.Point(321, 54);
            this.gb1.Margin = new System.Windows.Forms.Padding(2);
            this.gb1.Name = "gb1";
            this.gb1.Padding = new System.Windows.Forms.Padding(2);
            this.gb1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gb1.Size = new System.Drawing.Size(224, 100);
            this.gb1.TabIndex = 0;
            this.gb1.TabStop = false;
            this.gb1.Text = "电信号";
            this.gb1.Enter += new System.EventHandler(this.gb1_Enter);
            // 
            // rxRate
            // 
            this.rxRate.BackColor = System.Drawing.Color.White;
            this.rxRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rxRate.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rxRate.Location = new System.Drawing.Point(111, 65);
            this.rxRate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.rxRate.Name = "rxRate";
            this.rxRate.Size = new System.Drawing.Size(108, 27);
            this.rxRate.TabIndex = 3;
            this.rxRate.Text = "...mV";
            // 
            // txRate
            // 
            this.txRate.BackColor = System.Drawing.Color.White;
            this.txRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txRate.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txRate.Location = new System.Drawing.Point(111, 30);
            this.txRate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txRate.Name = "txRate";
            this.txRate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txRate.Size = new System.Drawing.Size(108, 27);
            this.txRate.TabIndex = 1;
            this.txRate.Text = "...MHZ";
            this.txRate.Click += new System.EventHandler(this.txRate_Click);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Segoe Print", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(21, 7);
            this.label26.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(92, 38);
            this.label26.TabIndex = 1;
            this.label26.Text = "Master";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::serialDome.Properties.Resources.logo1;
            this.pictureBox1.Location = new System.Drawing.Point(418, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 50);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(115, 14);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(24, 24);
            this.button2.TabIndex = 11;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.groupBox5);
            this.panel1.Controls.Add(this.groupBox7);
            this.panel1.Location = new System.Drawing.Point(-1, 274);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(594, 133);
            this.panel1.TabIndex = 16;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.button9);
            this.groupBox5.Controls.Add(this.button10);
            this.groupBox5.Controls.Add(this.button3);
            this.groupBox5.Controls.Add(this.comboBox4);
            this.groupBox5.Controls.Add(this.numericUpDown4);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox5.Location = new System.Drawing.Point(303, 14);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox5.Size = new System.Drawing.Size(287, 99);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "信道光信号参数设置";
            this.groupBox5.Enter += new System.EventHandler(this.groupBox5_Enter);
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "6MHZ",
            "12MHZ",
            "25MHZ"});
            this.comboBox3.Location = new System.Drawing.Point(90, 23);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(123, 27);
            this.comboBox3.TabIndex = 8;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "0",
            "1",
            "2"});
            this.comboBox4.Location = new System.Drawing.Point(97, 29);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 27);
            this.comboBox4.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(4, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "PMT灵敏度：";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(4, 30);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 26);
            this.label4.TabIndex = 0;
            this.label4.Text = "光功率强度：";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label14);
            this.groupBox7.Controls.Add(this.comboBox3);
            this.groupBox7.Controls.Add(this.button5);
            this.groupBox7.Controls.Add(this.button1);
            this.groupBox7.Controls.Add(this.numericUpDown3);
            this.groupBox7.Controls.Add(this.button7);
            this.groupBox7.Controls.Add(this.label8);
            this.groupBox7.Controls.Add(this.label10);
            this.groupBox7.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox7.Location = new System.Drawing.Point(6, 14);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox7.Size = new System.Drawing.Size(282, 102);
            this.groupBox7.TabIndex = 1;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "电信号参数设置";
            this.groupBox7.UseWaitCursor = true;
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(90, 62);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            3260,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(85, 27);
            this.numericUpDown3.TabIndex = 7;
            this.numericUpDown3.UseWaitCursor = true;
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Location = new System.Drawing.Point(97, 66);
            this.numericUpDown4.Maximum = new decimal(new int[] {
            1100,
            0,
            0,
            0});
            this.numericUpDown4.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(82, 27);
            this.numericUpDown4.TabIndex = 6;
            this.numericUpDown4.UseWaitCursor = true;
            this.numericUpDown4.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(218, 25);
            this.button7.Margin = new System.Windows.Forms.Padding(2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(59, 25);
            this.button7.TabIndex = 4;
            this.button7.Text = "确定";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.UseWaitCursor = true;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(4, 66);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 26);
            this.label8.TabIndex = 2;
            this.label8.Text = "比较器阈值：";
            this.label8.UseWaitCursor = true;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(4, 30);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 26);
            this.label10.TabIndex = 0;
            this.label10.Text = "传输速率：";
            this.label10.UseWaitCursor = true;
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(219, 62);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(27, 25);
            this.button1.TabIndex = 8;
            this.button1.Text = "确定";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.UseWaitCursor = true;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(250, 62);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(27, 25);
            this.button5.TabIndex = 14;
            this.button5.Text = "取消";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.UseWaitCursor = true;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(225, 29);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(58, 25);
            this.button3.TabIndex = 14;
            this.button3.Text = "确定";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.UseWaitCursor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Location = new System.Drawing.Point(256, 65);
            this.button9.Margin = new System.Windows.Forms.Padding(2);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(27, 25);
            this.button9.TabIndex = 15;
            this.button9.Text = "取消";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.UseWaitCursor = true;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button10.ForeColor = System.Drawing.Color.White;
            this.button10.Location = new System.Drawing.Point(225, 65);
            this.button10.Margin = new System.Windows.Forms.Padding(2);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(27, 25);
            this.button10.TabIndex = 16;
            this.button10.Text = "确定";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.UseWaitCursor = true;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(4, 31);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 26);
            this.label3.TabIndex = 15;
            this.label3.Text = "传输速率：";
            this.label3.UseWaitCursor = true;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(7, 65);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 26);
            this.label6.TabIndex = 15;
            this.label6.Text = "比较器阈值：";
            this.label6.UseWaitCursor = true;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(182, 67);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 26);
            this.label12.TabIndex = 14;
            this.label12.Text = "mV";
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.Location = new System.Drawing.Point(176, 62);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(39, 26);
            this.label14.TabIndex = 17;
            this.label14.Text = "mV";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(614, 509);
            this.Controls.Add(this.pn_master);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(15, 60, 15, 16);
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.TransparencyKey = System.Drawing.Color.Ivory;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.pn_master.ResumeLayout(false);
            this.pn_master.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gb1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.IO.Ports.SerialPort master;
		private System.Windows.Forms.ComboBox sw_com;
		private System.Windows.Forms.Button swtich;
		private System.Windows.Forms.PictureBox pictureBox1;
		private MetroFramework.Controls.MetroPanel metroPanel1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel pn_master;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Label statu;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label ber_cn;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label ber;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label pmt;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label power;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label cn_rx;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label cn_tx;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.GroupBox gb1;
		private System.Windows.Forms.Label rxRate;
		private System.Windows.Forms.Label txRate;
		private System.Windows.Forms.Label label26;
		private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
    }
}

