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
<<<<<<< HEAD
=======
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
>>>>>>> ecce09b9212c6822719867dd9c3155ebb2e9b5ee
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.master = new System.IO.Ports.SerialPort(this.components);
            this.sw_com = new System.Windows.Forms.ComboBox();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.swtich = new System.Windows.Forms.Button();
            this.pn_master = new System.Windows.Forms.Panel();
<<<<<<< HEAD
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.auto_save = new System.Windows.Forms.Button();
            this.label24 = new System.Windows.Forms.Label();
            this.save_interval = new System.Windows.Forms.NumericUpDown();
            this.change_file = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.filepath = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.save_data = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label33 = new System.Windows.Forms.Label();
            this.LightPower = new System.Windows.Forms.TextBox();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.tx_hum = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.tx_tem = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.pmt_init = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.pmt = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.rx_hum = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.rx_tem = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.damping = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.rx_power = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
=======
            this.reset = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.TDD_modu = new System.Windows.Forms.TextBox();
            this.TDD_rate = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.TDD_ratio = new System.Windows.Forms.TextBox();
            this.TDD_type = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.statu = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.draw_clear = new System.Windows.Forms.Button();
            this.angle_l = new System.Windows.Forms.TextBox();
            this.angle_v = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.auto = new System.Windows.Forms.RadioButton();
            this.manual = new System.Windows.Forms.RadioButton();
            this.label17 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
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
>>>>>>> ecce09b9212c6822719867dd9c3155ebb2e9b5ee
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cn_rx = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cn_tx = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.gb1 = new System.Windows.Forms.GroupBox();
<<<<<<< HEAD
            this.thres = new System.Windows.Forms.Label();
            this.txRate = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ber_cn = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ber = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.power = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.statu_ms = new System.Windows.Forms.Label();
            this.ch_ms = new System.Windows.Forms.Button();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.PmtSave = new System.Windows.Forms.Button();
            this.PmtSet = new System.Windows.Forms.Button();
            this.PmtSetValue = new System.Windows.Forms.NumericUpDown();
            this.label18 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.dam_thres_interval = new System.Windows.Forms.NumericUpDown();
            this.label30 = new System.Windows.Forms.Label();
            this.autoch_thres = new System.Windows.Forms.Button();
            this.pl_autodam = new System.Windows.Forms.Panel();
            this.dam_end = new System.Windows.Forms.NumericUpDown();
            this.label25 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.dam_interval = new System.Windows.Forms.NumericUpDown();
            this.dam_init = new System.Windows.Forms.NumericUpDown();
            this.label20 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.autoch_dam = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tdd_num = new System.Windows.Forms.Label();
            this.statu = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.ThresSet = new System.Windows.Forms.Button();
            this.txSetValue = new System.Windows.Forms.ComboBox();
            this.ThresRetn = new System.Windows.Forms.Button();
            this.thresSetValue = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.TxSet = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.DampingSet = new System.Windows.Forms.Button();
            this.PmtRetn = new System.Windows.Forms.Button();
            this.PWSet = new System.Windows.Forms.Button();
            this.pwSetValue = new System.Windows.Forms.ComboBox();
            this.damSetValue = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.reset = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label31 = new System.Windows.Forms.Label();
            this.DataTableName = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.isOOK = new System.Windows.Forms.RadioButton();
            this.isPPM = new System.Windows.Forms.RadioButton();
            this.metroPanel1.SuspendLayout();
            this.pn_master.SuspendLayout();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.save_interval)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox14.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gb1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PmtSetValue)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dam_thres_interval)).BeginInit();
            this.pl_autodam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dam_end)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dam_interval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dam_init)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thresSetValue)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.damSetValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.groupBox15.SuspendLayout();
=======
            this.rxRate = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.txRate = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pn_set = new System.Windows.Forms.Panel();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.set_rate_r = new System.Windows.Forms.TextBox();
            this.set_rate_t = new System.Windows.Forms.TextBox();
            this.cancl_rate = new System.Windows.Forms.Button();
            this.confm_rate = new System.Windows.Forms.Button();
            this.label28 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.cancl_set = new System.Windows.Forms.Button();
            this.confm_set = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.set_dis = new System.Windows.Forms.TextBox();
            this.concl_dis = new System.Windows.Forms.Button();
            this.confm_dis = new System.Windows.Forms.Button();
            this.label32 = new System.Windows.Forms.Label();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.set_rate = new System.Windows.Forms.TextBox();
            this.set_ratio = new System.Windows.Forms.TextBox();
            this.cancl_tdd = new System.Windows.Forms.Button();
            this.confm_tdd = new System.Windows.Forms.Button();
            this.label34 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.pn_slave = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button13 = new System.Windows.Forms.Button();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label37 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label39 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label41 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.label43 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label45 = new System.Windows.Forms.Label();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.label46 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.label50 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.label54 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.label57 = new System.Windows.Forms.Label();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.label58 = new System.Windows.Forms.Label();
            this.label59 = new System.Windows.Forms.Label();
            this.label60 = new System.Windows.Forms.Label();
            this.label61 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroPanel1.SuspendLayout();
            this.pn_master.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gb1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pn_set.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.pn_slave.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.panel6.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.groupBox12.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.groupBox14.SuspendLayout();
            this.groupBox15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
>>>>>>> ecce09b9212c6822719867dd9c3155ebb2e9b5ee
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
<<<<<<< HEAD
            this.sw_com.Location = new System.Drawing.Point(111, 14);
            this.sw_com.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sw_com.Name = "sw_com";
            this.sw_com.Size = new System.Drawing.Size(125, 31);
=======
            this.sw_com.Location = new System.Drawing.Point(152, 9);
            this.sw_com.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sw_com.Name = "sw_com";
            this.sw_com.Size = new System.Drawing.Size(133, 31);
>>>>>>> ecce09b9212c6822719867dd9c3155ebb2e9b5ee
            this.sw_com.TabIndex = 0;
            this.sw_com.Click += new System.EventHandler(this.sw_com_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.sw_com);
            this.metroPanel1.Controls.Add(this.label2);
            this.metroPanel1.Controls.Add(this.swtich);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 12;
<<<<<<< HEAD
            this.metroPanel1.Location = new System.Drawing.Point(157, 22);
            this.metroPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(436, 58);
=======
            this.metroPanel1.Location = new System.Drawing.Point(15, 25);
            this.metroPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(492, 58);
>>>>>>> ecce09b9212c6822719867dd9c3155ebb2e9b5ee
            this.metroPanel1.TabIndex = 11;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
<<<<<<< HEAD
            this.label2.Location = new System.Drawing.Point(4, 16);
=======
            this.label2.Location = new System.Drawing.Point(24, 16);
>>>>>>> ecce09b9212c6822719867dd9c3155ebb2e9b5ee
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 27);
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
<<<<<<< HEAD
            this.swtich.Image = ((System.Drawing.Image)(resources.GetObject("swtich.Image")));
            this.swtich.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.swtich.Location = new System.Drawing.Point(251, 9);
            this.swtich.Margin = new System.Windows.Forms.Padding(0);
            this.swtich.Name = "swtich";
            this.swtich.Size = new System.Drawing.Size(177, 44);
=======
            this.swtich.Image = global::serialDome.Properties.Resources.off;
            this.swtich.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.swtich.Location = new System.Drawing.Point(324, 2);
            this.swtich.Margin = new System.Windows.Forms.Padding(0);
            this.swtich.Name = "swtich";
            this.swtich.Size = new System.Drawing.Size(152, 49);
>>>>>>> ecce09b9212c6822719867dd9c3155ebb2e9b5ee
            this.swtich.TabIndex = 6;
            this.swtich.Text = "打开串口";
            this.swtich.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.swtich.UseVisualStyleBackColor = false;
            this.swtich.Click += new System.EventHandler(this.switch_Click);
            // 
            // pn_master
            // 
            this.pn_master.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
<<<<<<< HEAD
            this.pn_master.Controls.Add(this.groupBox9);
            this.pn_master.Controls.Add(this.panel2);
            this.pn_master.Controls.Add(this.panel1);
            this.pn_master.Location = new System.Drawing.Point(23, 86);
            this.pn_master.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pn_master.Name = "pn_master";
            this.pn_master.Size = new System.Drawing.Size(1050, 621);
            this.pn_master.TabIndex = 13;
            this.pn_master.Paint += new System.Windows.Forms.PaintEventHandler(this.pn_master_Paint);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.panel4);
            this.groupBox9.Controls.Add(this.label31);
            this.groupBox9.Controls.Add(this.auto_save);
            this.groupBox9.Controls.Add(this.label24);
            this.groupBox9.Controls.Add(this.save_interval);
            this.groupBox9.Controls.Add(this.change_file);
            this.groupBox9.Controls.Add(this.panel3);
            this.groupBox9.Controls.Add(this.label23);
            this.groupBox9.Controls.Add(this.save_data);
            this.groupBox9.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox9.Location = new System.Drawing.Point(673, 229);
            this.groupBox9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox9.Size = new System.Drawing.Size(346, 331);
            this.groupBox9.TabIndex = 6;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "数据保存";
            // 
            // auto_save
            // 
            this.auto_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.auto_save.BackColor = System.Drawing.Color.White;
            this.auto_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.auto_save.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.auto_save.FlatAppearance.BorderSize = 0;
            this.auto_save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.auto_save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.auto_save.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.auto_save.Image = ((System.Drawing.Image)(resources.GetObject("auto_save.Image")));
            this.auto_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.auto_save.Location = new System.Drawing.Point(26, 283);
            this.auto_save.Margin = new System.Windows.Forms.Padding(0);
            this.auto_save.Name = "auto_save";
            this.auto_save.Size = new System.Drawing.Size(290, 36);
            this.auto_save.TabIndex = 24;
            this.auto_save.Text = "开始自动保存数据";
            this.auto_save.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.auto_save.UseVisualStyleBackColor = false;
            this.auto_save.Click += new System.EventHandler(this.auto_save_Click);
            // 
            // label24
            // 
            this.label24.Cursor = System.Windows.Forms.Cursors.Default;
            this.label24.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label24.Location = new System.Drawing.Point(251, 149);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(48, 32);
            this.label24.TabIndex = 23;
            this.label24.Text = "ms";
            // 
            // save_interval
            // 
            this.save_interval.Location = new System.Drawing.Point(154, 151);
            this.save_interval.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.save_interval.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.save_interval.Name = "save_interval";
            this.save_interval.Size = new System.Drawing.Size(91, 31);
            this.save_interval.TabIndex = 22;
            this.save_interval.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // change_file
            // 
            this.change_file.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.change_file.FlatAppearance.BorderSize = 0;
            this.change_file.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.change_file.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.change_file.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.change_file.Location = new System.Drawing.Point(27, 109);
            this.change_file.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.change_file.Name = "change_file";
            this.change_file.Size = new System.Drawing.Size(144, 39);
            this.change_file.TabIndex = 18;
            this.change_file.Text = "修改默认文件";
            this.change_file.UseVisualStyleBackColor = false;
            this.change_file.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.filepath);
            this.panel3.Location = new System.Drawing.Point(27, 25);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(289, 75);
            this.panel3.TabIndex = 13;
            // 
            // filepath
            // 
            this.filepath.BackColor = System.Drawing.Color.White;
            this.filepath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.filepath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filepath.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.filepath.Location = new System.Drawing.Point(0, 0);
            this.filepath.Name = "filepath";
            this.filepath.Size = new System.Drawing.Size(289, 75);
            this.filepath.TabIndex = 14;
            this.filepath.Text = "默认保存到C:\\File\\Data\\TestData\\Data.xlsx";
            this.filepath.Click += new System.EventHandler(this.filepath_Click);
            // 
            // label23
            // 
            this.label23.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label23.Location = new System.Drawing.Point(21, 152);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(205, 32);
            this.label23.TabIndex = 15;
            this.label23.Text = "自动保存周期：";
            // 
            // save_data
            // 
            this.save_data.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.save_data.FlatAppearance.BorderSize = 0;
            this.save_data.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save_data.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.save_data.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.save_data.Location = new System.Drawing.Point(191, 109);
            this.save_data.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.save_data.Name = "save_data";
            this.save_data.Size = new System.Drawing.Size(109, 39);
            this.save_data.TabIndex = 11;
            this.save_data.Text = "保存数据";
            this.save_data.UseVisualStyleBackColor = false;
            this.save_data.Click += new System.EventHandler(this.save_data_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label33);
            this.panel2.Controls.Add(this.LightPower);
            this.panel2.Controls.Add(this.groupBox14);
            this.panel2.Controls.Add(this.groupBox13);
            this.panel2.Controls.Add(this.groupBox12);
            this.panel2.Controls.Add(this.groupBox8);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.gb1);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Location = new System.Drawing.Point(3, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1033, 223);
            this.panel2.TabIndex = 7;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(903, 128);
            this.label33.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(112, 15);
            this.label33.TabIndex = 10;
            this.label33.Text = "光功率计示数：";
            // 
            // LightPower
            // 
            this.LightPower.Location = new System.Drawing.Point(906, 157);
            this.LightPower.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LightPower.Name = "LightPower";
            this.LightPower.Size = new System.Drawing.Size(120, 25);
            this.LightPower.TabIndex = 9;
            this.LightPower.TextChanged += new System.EventHandler(this.LightPower_TextChanged);
            this.LightPower.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LightPower_KeyDown);
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.tx_hum);
            this.groupBox14.Controls.Add(this.label36);
            this.groupBox14.Controls.Add(this.tx_tem);
            this.groupBox14.Controls.Add(this.label38);
            this.groupBox14.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox14.Location = new System.Drawing.Point(669, 2);
            this.groupBox14.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox14.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox14.Size = new System.Drawing.Size(152, 101);
            this.groupBox14.TabIndex = 8;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "发射仓温湿度";
            // 
            // tx_hum
            // 
            this.tx_hum.BackColor = System.Drawing.Color.White;
            this.tx_hum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tx_hum.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tx_hum.Location = new System.Drawing.Point(67, 62);
            this.tx_hum.Name = "tx_hum";
            this.tx_hum.Size = new System.Drawing.Size(59, 33);
            this.tx_hum.TabIndex = 3;
            this.tx_hum.Text = "00%";
            // 
            // label36
            // 
            this.label36.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label36.Location = new System.Drawing.Point(7, 65);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(136, 29);
            this.label36.TabIndex = 2;
            this.label36.Text = "湿度：";
            this.label36.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tx_tem
            // 
            this.tx_tem.BackColor = System.Drawing.Color.White;
            this.tx_tem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tx_tem.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tx_tem.Location = new System.Drawing.Point(67, 28);
            this.tx_tem.Name = "tx_tem";
            this.tx_tem.Size = new System.Drawing.Size(59, 33);
            this.tx_tem.TabIndex = 1;
            this.tx_tem.Text = "00℃";
            // 
            // label38
            // 
            this.label38.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label38.Location = new System.Drawing.Point(7, 25);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(136, 32);
            this.label38.TabIndex = 0;
            this.label38.Text = "温度：";
            this.label38.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.pmt_init);
            this.groupBox13.Controls.Add(this.label35);
            this.groupBox13.Controls.Add(this.pmt);
            this.groupBox13.Controls.Add(this.label15);
            this.groupBox13.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox13.Location = new System.Drawing.Point(621, 109);
            this.groupBox13.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox13.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox13.Size = new System.Drawing.Size(275, 102);
            this.groupBox13.TabIndex = 7;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "PMT增益";
            // 
            // pmt_init
            // 
            this.pmt_init.BackColor = System.Drawing.Color.White;
            this.pmt_init.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pmt_init.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pmt_init.Location = new System.Drawing.Point(115, 64);
            this.pmt_init.Name = "pmt_init";
            this.pmt_init.Size = new System.Drawing.Size(154, 33);
            this.pmt_init.TabIndex = 3;
            this.pmt_init.Text = "000mV";
            // 
            // label35
            // 
            this.label35.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label35.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label35.Location = new System.Drawing.Point(5, 61);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(136, 32);
            this.label35.TabIndex = 4;
            this.label35.Text = "默认增益：";
            this.label35.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pmt
            // 
            this.pmt.BackColor = System.Drawing.Color.White;
            this.pmt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pmt.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pmt.Location = new System.Drawing.Point(115, 20);
            this.pmt.Name = "pmt";
            this.pmt.Size = new System.Drawing.Size(154, 33);
            this.pmt.TabIndex = 1;
            this.pmt.Text = "0000mV";
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label15.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label15.Location = new System.Drawing.Point(5, 25);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(136, 32);
            this.label15.TabIndex = 2;
            this.label15.Text = "当前增益：";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.rx_hum);
            this.groupBox12.Controls.Add(this.label29);
            this.groupBox12.Controls.Add(this.rx_tem);
            this.groupBox12.Controls.Add(this.label34);
            this.groupBox12.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox12.Location = new System.Drawing.Point(501, 2);
            this.groupBox12.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox12.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox12.Size = new System.Drawing.Size(163, 101);
            this.groupBox12.TabIndex = 6;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "接收仓温湿度";
            // 
            // rx_hum
            // 
            this.rx_hum.BackColor = System.Drawing.Color.White;
            this.rx_hum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rx_hum.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rx_hum.Location = new System.Drawing.Point(63, 62);
            this.rx_hum.Name = "rx_hum";
            this.rx_hum.Size = new System.Drawing.Size(65, 33);
            this.rx_hum.TabIndex = 3;
            this.rx_hum.Text = "00%";
            // 
            // label29
            // 
            this.label29.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label29.Location = new System.Drawing.Point(7, 65);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(136, 29);
            this.label29.TabIndex = 2;
            this.label29.Text = "湿度：";
            this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rx_tem
            // 
            this.rx_tem.BackColor = System.Drawing.Color.White;
            this.rx_tem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rx_tem.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rx_tem.Location = new System.Drawing.Point(63, 24);
            this.rx_tem.Name = "rx_tem";
            this.rx_tem.Size = new System.Drawing.Size(65, 33);
            this.rx_tem.TabIndex = 1;
            this.rx_tem.Text = "00℃";
            // 
            // label34
            // 
            this.label34.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label34.Location = new System.Drawing.Point(7, 25);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(136, 32);
            this.label34.TabIndex = 0;
            this.label34.Text = "温度：";
            this.label34.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.damping);
            this.groupBox8.Controls.Add(this.label13);
            this.groupBox8.Controls.Add(this.rx_power);
            this.groupBox8.Controls.Add(this.label26);
            this.groupBox8.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox8.Location = new System.Drawing.Point(311, 108);
            this.groupBox8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox8.Size = new System.Drawing.Size(296, 102);
            this.groupBox8.TabIndex = 5;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "接收光信号";
            // 
            // damping
            // 
            this.damping.BackColor = System.Drawing.Color.White;
            this.damping.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.damping.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.damping.Location = new System.Drawing.Point(121, 64);
            this.damping.Name = "damping";
            this.damping.Size = new System.Drawing.Size(169, 33);
            this.damping.TabIndex = 3;
            this.damping.Text = "0000.000mV";
            this.damping.Click += new System.EventHandler(this.damping_Click);
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(8, 61);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(136, 32);
            this.label13.TabIndex = 2;
            this.label13.Text = "衰减片电压：";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // rx_power
            // 
            this.rx_power.BackColor = System.Drawing.Color.White;
            this.rx_power.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rx_power.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rx_power.Location = new System.Drawing.Point(121, 24);
            this.rx_power.Name = "rx_power";
            this.rx_power.Size = new System.Drawing.Size(169, 33);
            this.rx_power.TabIndex = 1;
            this.rx_power.Text = "0.0000V";
            // 
            // label26
            // 
            this.label26.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label26.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label26.Location = new System.Drawing.Point(8, 25);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(136, 32);
            this.label26.TabIndex = 0;
            this.label26.Text = "光强电压：";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cn_rx);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cn_tx);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(5, -1);
=======
            this.pn_master.Controls.Add(this.reset);
            this.pn_master.Controls.Add(this.groupBox5);
            this.pn_master.Controls.Add(this.panel4);
            this.pn_master.Controls.Add(this.groupBox4);
            this.pn_master.Controls.Add(this.groupBox2);
            this.pn_master.Controls.Add(this.groupBox3);
            this.pn_master.Controls.Add(this.groupBox1);
            this.pn_master.Controls.Add(this.gb1);
            this.pn_master.Controls.Add(this.label26);
            this.pn_master.Location = new System.Drawing.Point(140, 94);
            this.pn_master.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pn_master.Name = "pn_master";
            this.pn_master.Size = new System.Drawing.Size(1231, 337);
            this.pn_master.TabIndex = 13;
            // 
            // reset
            // 
            this.reset.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.reset.FlatAppearance.BorderSize = 0;
            this.reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reset.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.reset.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.reset.Location = new System.Drawing.Point(469, 24);
            this.reset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(113, 38);
            this.reset.TabIndex = 10;
            this.reset.Text = "复位";
            this.reset.UseVisualStyleBackColor = false;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.TDD_modu);
            this.groupBox5.Controls.Add(this.TDD_rate);
            this.groupBox5.Controls.Add(this.label22);
            this.groupBox5.Controls.Add(this.label23);
            this.groupBox5.Controls.Add(this.TDD_ratio);
            this.groupBox5.Controls.Add(this.TDD_type);
            this.groupBox5.Controls.Add(this.label18);
            this.groupBox5.Controls.Add(this.label20);
            this.groupBox5.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox5.Location = new System.Drawing.Point(620, 10);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Size = new System.Drawing.Size(603, 119);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "TDD帧结构";
            // 
            // TDD_modu
            // 
            this.TDD_modu.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TDD_modu.Location = new System.Drawing.Point(419, 74);
            this.TDD_modu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TDD_modu.Name = "TDD_modu";
            this.TDD_modu.Size = new System.Drawing.Size(165, 31);
            this.TDD_modu.TabIndex = 13;
            // 
            // TDD_rate
            // 
            this.TDD_rate.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TDD_rate.Location = new System.Drawing.Point(419, 30);
            this.TDD_rate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TDD_rate.Name = "TDD_rate";
            this.TDD_rate.Size = new System.Drawing.Size(165, 31);
            this.TDD_rate.TabIndex = 12;
            // 
            // label22
            // 
            this.label22.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label22.Location = new System.Drawing.Point(312, 78);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(143, 32);
            this.label22.TabIndex = 11;
            this.label22.Text = "调制格式：";
            // 
            // label23
            // 
            this.label23.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label23.Location = new System.Drawing.Point(312, 36);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(143, 32);
            this.label23.TabIndex = 10;
            this.label23.Text = "码率：";
            // 
            // TDD_ratio
            // 
            this.TDD_ratio.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TDD_ratio.Location = new System.Drawing.Point(137, 75);
            this.TDD_ratio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TDD_ratio.Name = "TDD_ratio";
            this.TDD_ratio.Size = new System.Drawing.Size(149, 31);
            this.TDD_ratio.TabIndex = 9;
            // 
            // TDD_type
            // 
            this.TDD_type.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TDD_type.Location = new System.Drawing.Point(137, 36);
            this.TDD_type.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TDD_type.Name = "TDD_type";
            this.TDD_type.Size = new System.Drawing.Size(149, 31);
            this.TDD_type.TabIndex = 8;
            // 
            // label18
            // 
            this.label18.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label18.Location = new System.Drawing.Point(5, 78);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(143, 32);
            this.label18.TabIndex = 6;
            this.label18.Text = "当前时隙比：";
            // 
            // label20
            // 
            this.label20.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label20.Location = new System.Drawing.Point(9, 38);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(143, 32);
            this.label20.TabIndex = 4;
            this.label20.Text = "帧类型：";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.statu);
            this.panel4.Controls.Add(this.label16);
            this.panel4.Location = new System.Drawing.Point(220, 10);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(164, 44);
            this.panel4.TabIndex = 6;
            // 
            // statu
            // 
            this.statu.BackColor = System.Drawing.SystemColors.Control;
            this.statu.Font = new System.Drawing.Font("微软雅黑 Light", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.statu.Location = new System.Drawing.Point(104, 8);
            this.statu.Name = "statu";
            this.statu.Size = new System.Drawing.Size(59, 22);
            this.statu.TabIndex = 1;
            this.statu.Text = "断线";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label16.Location = new System.Drawing.Point(3, 6);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(107, 26);
            this.label16.TabIndex = 0;
            this.label16.Text = "通信状态：";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.draw_clear);
            this.groupBox4.Controls.Add(this.angle_l);
            this.groupBox4.Controls.Add(this.angle_v);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.label21);
            this.groupBox4.Controls.Add(this.panel5);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.chart1);
            this.groupBox4.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox4.Location = new System.Drawing.Point(620, 135);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(603, 186);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "云台控制";
            // 
            // draw_clear
            // 
            this.draw_clear.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.draw_clear.FlatAppearance.BorderSize = 0;
            this.draw_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.draw_clear.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.draw_clear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.draw_clear.Location = new System.Drawing.Point(511, 100);
            this.draw_clear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.draw_clear.Name = "draw_clear";
            this.draw_clear.Size = new System.Drawing.Size(75, 68);
            this.draw_clear.TabIndex = 11;
            this.draw_clear.Text = "清除图像";
            this.draw_clear.UseVisualStyleBackColor = false;
            this.draw_clear.Click += new System.EventHandler(this.draw_clear_Click);
            // 
            // angle_l
            // 
            this.angle_l.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.angle_l.Location = new System.Drawing.Point(148, 132);
            this.angle_l.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.angle_l.Name = "angle_l";
            this.angle_l.Size = new System.Drawing.Size(139, 31);
            this.angle_l.TabIndex = 9;
            // 
            // angle_v
            // 
            this.angle_v.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.angle_v.Location = new System.Drawing.Point(148, 91);
            this.angle_v.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.angle_v.Name = "angle_v";
            this.angle_v.Size = new System.Drawing.Size(139, 31);
            this.angle_v.TabIndex = 8;
            // 
            // label19
            // 
            this.label19.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label19.Location = new System.Drawing.Point(5, 135);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(143, 32);
            this.label19.TabIndex = 6;
            this.label19.Text = "云台水平角：";
            // 
            // label21
            // 
            this.label21.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label21.Location = new System.Drawing.Point(5, 91);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(143, 32);
            this.label21.TabIndex = 4;
            this.label21.Text = "云台俯仰角：";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.auto);
            this.panel5.Controls.Add(this.manual);
            this.panel5.Location = new System.Drawing.Point(148, 42);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(140, 38);
            this.panel5.TabIndex = 0;
            // 
            // auto
            // 
            this.auto.Checked = true;
            this.auto.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.auto.Location = new System.Drawing.Point(65, 2);
            this.auto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.auto.Name = "auto";
            this.auto.Size = new System.Drawing.Size(75, 34);
            this.auto.TabIndex = 1;
            this.auto.TabStop = true;
            this.auto.Text = "自动";
            this.auto.UseVisualStyleBackColor = true;
            // 
            // manual
            // 
            this.manual.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.manual.Location = new System.Drawing.Point(3, 1);
            this.manual.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.manual.Name = "manual";
            this.manual.Size = new System.Drawing.Size(68, 34);
            this.manual.TabIndex = 0;
            this.manual.Text = "手动";
            this.manual.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label17.Location = new System.Drawing.Point(5, 48);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(157, 32);
            this.label17.TabIndex = 1;
            this.label17.Text = "对准模式：";
            // 
            // chart1
            // 
            chartArea1.AxisX.LabelStyle.Enabled = false;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisY.MajorGrid.Enabled = false;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(272, 15);
            this.chart1.Margin = new System.Windows.Forms.Padding(4);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "P";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(324, 162);
            this.chart1.TabIndex = 10;
            this.chart1.Text = "chart1";
            title1.Name = "title";
            title1.Text = "实时光强曲线";
            this.chart1.Titles.Add(title1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ber_cn);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.ber);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(3, 198);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox2.Size = new System.Drawing.Size(299, 124);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "信道误码";
            // 
            // ber_cn
            // 
            this.ber_cn.BackColor = System.Drawing.Color.White;
            this.ber_cn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ber_cn.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ber_cn.Location = new System.Drawing.Point(148, 82);
            this.ber_cn.Name = "ber_cn";
            this.ber_cn.Size = new System.Drawing.Size(139, 33);
            this.ber_cn.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(5, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(157, 32);
            this.label9.TabIndex = 2;
            this.label9.Text = "误码数据量：";
            // 
            // ber
            // 
            this.ber.BackColor = System.Drawing.Color.White;
            this.ber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ber.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ber.Location = new System.Drawing.Point(148, 38);
            this.ber.Name = "ber";
            this.ber.Size = new System.Drawing.Size(139, 33);
            this.ber.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(5, 38);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(143, 32);
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
            this.groupBox3.Location = new System.Drawing.Point(316, 198);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox3.Size = new System.Drawing.Size(299, 124);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "信道光信号";
            // 
            // pmt
            // 
            this.pmt.BackColor = System.Drawing.Color.White;
            this.pmt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pmt.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pmt.Location = new System.Drawing.Point(148, 81);
            this.pmt.Name = "pmt";
            this.pmt.Size = new System.Drawing.Size(143, 33);
            this.pmt.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(5, 82);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(136, 32);
            this.label13.TabIndex = 2;
            this.label13.Text = "PMT灵敏度：";
            // 
            // power
            // 
            this.power.BackColor = System.Drawing.Color.White;
            this.power.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.power.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.power.Location = new System.Drawing.Point(148, 38);
            this.power.Name = "power";
            this.power.Size = new System.Drawing.Size(143, 33);
            this.power.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label15.Location = new System.Drawing.Point(5, 38);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(136, 32);
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
            this.groupBox1.Location = new System.Drawing.Point(3, 66);
>>>>>>> ecce09b9212c6822719867dd9c3155ebb2e9b5ee
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
<<<<<<< HEAD
            this.groupBox1.Size = new System.Drawing.Size(211, 104);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "数据吞吐量";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
=======
            this.groupBox1.Size = new System.Drawing.Size(299, 125);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "数据吞吐量";
>>>>>>> ecce09b9212c6822719867dd9c3155ebb2e9b5ee
            // 
            // cn_rx
            // 
            this.cn_rx.BackColor = System.Drawing.Color.White;
            this.cn_rx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cn_rx.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
<<<<<<< HEAD
            this.cn_rx.Location = new System.Drawing.Point(107, 64);
            this.cn_rx.Name = "cn_rx";
            this.cn_rx.Size = new System.Drawing.Size(93, 33);
            this.cn_rx.TabIndex = 3;
            this.cn_rx.Text = "0帧/s";
=======
            this.cn_rx.Location = new System.Drawing.Point(149, 81);
            this.cn_rx.Name = "cn_rx";
            this.cn_rx.Size = new System.Drawing.Size(139, 33);
            this.cn_rx.TabIndex = 3;
>>>>>>> ecce09b9212c6822719867dd9c3155ebb2e9b5ee
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
<<<<<<< HEAD
            this.label5.Location = new System.Drawing.Point(5, 66);
=======
            this.label5.Location = new System.Drawing.Point(5, 82);
>>>>>>> ecce09b9212c6822719867dd9c3155ebb2e9b5ee
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "接收总量：";
            // 
            // cn_tx
            // 
            this.cn_tx.BackColor = System.Drawing.Color.White;
            this.cn_tx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cn_tx.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
<<<<<<< HEAD
            this.cn_tx.Location = new System.Drawing.Point(105, 25);
            this.cn_tx.Name = "cn_tx";
            this.cn_tx.Size = new System.Drawing.Size(95, 33);
            this.cn_tx.TabIndex = 1;
            this.cn_tx.Text = "0帧/s";
=======
            this.cn_tx.Location = new System.Drawing.Point(148, 38);
            this.cn_tx.Name = "cn_tx";
            this.cn_tx.Size = new System.Drawing.Size(139, 33);
            this.cn_tx.TabIndex = 1;
>>>>>>> ecce09b9212c6822719867dd9c3155ebb2e9b5ee
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
<<<<<<< HEAD
            this.label7.Location = new System.Drawing.Point(5, 29);
=======
            this.label7.Location = new System.Drawing.Point(5, 38);
>>>>>>> ecce09b9212c6822719867dd9c3155ebb2e9b5ee
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "发送总量：";
            // 
            // gb1
            // 
<<<<<<< HEAD
            this.gb1.Controls.Add(this.thres);
            this.gb1.Controls.Add(this.txRate);
            this.gb1.Controls.Add(this.label6);
            this.gb1.Controls.Add(this.label3);
            this.gb1.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gb1.Location = new System.Drawing.Point(221, 0);
=======
            this.gb1.Controls.Add(this.rxRate);
            this.gb1.Controls.Add(this.label24);
            this.gb1.Controls.Add(this.txRate);
            this.gb1.Controls.Add(this.label25);
            this.gb1.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gb1.Location = new System.Drawing.Point(316, 66);
>>>>>>> ecce09b9212c6822719867dd9c3155ebb2e9b5ee
            this.gb1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gb1.Name = "gb1";
            this.gb1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gb1.RightToLeft = System.Windows.Forms.RightToLeft.No;
<<<<<<< HEAD
            this.gb1.Size = new System.Drawing.Size(275, 102);
            this.gb1.TabIndex = 0;
            this.gb1.TabStop = false;
            this.gb1.Text = "电信号";
            this.gb1.Enter += new System.EventHandler(this.gb1_Enter);
            // 
            // thres
            // 
            this.thres.BackColor = System.Drawing.Color.White;
            this.thres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.thres.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.thres.Location = new System.Drawing.Point(121, 62);
            this.thres.Name = "thres";
            this.thres.Size = new System.Drawing.Size(147, 33);
            this.thres.TabIndex = 3;
            this.thres.Text = "0mV";
=======
            this.gb1.Size = new System.Drawing.Size(299, 125);
            this.gb1.TabIndex = 0;
            this.gb1.TabStop = false;
            this.gb1.Text = "信号速率";
            // 
            // rxRate
            // 
            this.rxRate.BackColor = System.Drawing.Color.White;
            this.rxRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rxRate.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rxRate.Location = new System.Drawing.Point(148, 81);
            this.rxRate.Name = "rxRate";
            this.rxRate.Size = new System.Drawing.Size(143, 33);
            this.rxRate.TabIndex = 3;
            // 
            // label24
            // 
            this.label24.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label24.Location = new System.Drawing.Point(5, 82);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(117, 32);
            this.label24.TabIndex = 2;
            this.label24.Text = "接收速率：";
>>>>>>> ecce09b9212c6822719867dd9c3155ebb2e9b5ee
            // 
            // txRate
            // 
            this.txRate.BackColor = System.Drawing.Color.White;
            this.txRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txRate.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
<<<<<<< HEAD
            this.txRate.Location = new System.Drawing.Point(121, 21);
            this.txRate.Name = "txRate";
            this.txRate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txRate.Size = new System.Drawing.Size(147, 33);
            this.txRate.TabIndex = 1;
            this.txRate.Text = "xxMHZ";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(5, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 32);
            this.label6.TabIndex = 15;
            this.label6.Text = "比较器阈值：";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(8, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 32);
            this.label3.TabIndex = 15;
            this.label3.Text = "传输速率：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ber_cn);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.ber);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(7, 108);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox2.Size = new System.Drawing.Size(299, 102);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "信道误码";
            // 
            // ber_cn
            // 
            this.ber_cn.BackColor = System.Drawing.Color.White;
            this.ber_cn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ber_cn.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ber_cn.Location = new System.Drawing.Point(171, 64);
            this.ber_cn.Name = "ber_cn";
            this.ber_cn.Size = new System.Drawing.Size(115, 33);
            this.ber_cn.TabIndex = 3;
            this.ber_cn.Text = "0B/s";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(9, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(157, 32);
            this.label9.TabIndex = 2;
            this.label9.Text = "误码数据量：";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ber
            // 
            this.ber.BackColor = System.Drawing.Color.White;
            this.ber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ber.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ber.Location = new System.Drawing.Point(172, 20);
            this.ber.Name = "ber";
            this.ber.Size = new System.Drawing.Size(115, 33);
            this.ber.TabIndex = 1;
            this.ber.Text = "0";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label11.Location = new System.Drawing.Point(4, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(195, 32);
            this.label11.TabIndex = 0;
            this.label11.Text = " RS纠错失败比率：";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.power);
            this.groupBox3.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox3.Location = new System.Drawing.Point(827, 2);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox3.Size = new System.Drawing.Size(135, 101);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "激光器模式";
            // 
            // power
            // 
            this.power.BackColor = System.Drawing.Color.White;
            this.power.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.power.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.power.Location = new System.Drawing.Point(13, 31);
            this.power.Name = "power";
            this.power.Size = new System.Drawing.Size(101, 44);
            this.power.TabIndex = 1;
            this.power.Text = "全部关闭";
            this.power.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.groupBox15);
            this.panel1.Controls.Add(this.groupBox11);
            this.panel1.Controls.Add(this.groupBox6);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox7);
            this.panel1.Controls.Add(this.groupBox5);
            this.panel1.Location = new System.Drawing.Point(3, 229);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(665, 387);
            this.panel1.TabIndex = 12;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.statu_ms);
            this.groupBox10.Controls.Add(this.ch_ms);
            this.groupBox10.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Bold);
            this.groupBox10.Location = new System.Drawing.Point(746, 11);
            this.groupBox10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox10.Size = new System.Drawing.Size(223, 71);
            this.groupBox10.TabIndex = 14;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "主从状态";
            // 
            // statu_ms
            // 
            this.statu_ms.BackColor = System.Drawing.SystemColors.Window;
            this.statu_ms.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.statu_ms.Font = new System.Drawing.Font("Ink Free", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statu_ms.Location = new System.Drawing.Point(15, 32);
            this.statu_ms.Name = "statu_ms";
            this.statu_ms.Size = new System.Drawing.Size(66, 31);
            this.statu_ms.TabIndex = 1;
            this.statu_ms.Text = "主机";
            this.statu_ms.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.statu_ms.Click += new System.EventHandler(this.statu_ms_Click);
            // 
            // ch_ms
            // 
            this.ch_ms.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ch_ms.FlatAppearance.BorderSize = 0;
            this.ch_ms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ch_ms.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ch_ms.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ch_ms.Location = new System.Drawing.Point(91, 28);
            this.ch_ms.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ch_ms.Name = "ch_ms";
            this.ch_ms.Size = new System.Drawing.Size(113, 36);
            this.ch_ms.TabIndex = 10;
            this.ch_ms.Text = "主从切换";
            this.ch_ms.UseVisualStyleBackColor = false;
            this.ch_ms.Click += new System.EventHandler(this.ch_ms_Click);
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.PmtSave);
            this.groupBox11.Controls.Add(this.PmtSet);
            this.groupBox11.Controls.Add(this.PmtSetValue);
            this.groupBox11.Controls.Add(this.label18);
            this.groupBox11.Controls.Add(this.label32);
            this.groupBox11.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox11.Location = new System.Drawing.Point(7, 290);
            this.groupBox11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox11.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox11.Size = new System.Drawing.Size(379, 74);
            this.groupBox11.TabIndex = 18;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "PMT增益设置";
            // 
            // PmtSave
            // 
            this.PmtSave.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.PmtSave.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.PmtSave.FlatAppearance.BorderSize = 0;
            this.PmtSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PmtSave.Font = new System.Drawing.Font("微软雅黑", 6.6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PmtSave.ForeColor = System.Drawing.Color.White;
            this.PmtSave.Location = new System.Drawing.Point(288, 31);
            this.PmtSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PmtSave.Name = "PmtSave";
            this.PmtSave.Size = new System.Drawing.Size(84, 31);
            this.PmtSave.TabIndex = 23;
            this.PmtSave.Text = "设为默认";
            this.PmtSave.UseVisualStyleBackColor = false;
            this.PmtSave.Click += new System.EventHandler(this.PmtSave_Click);
            // 
            // PmtSet
            // 
            this.PmtSet.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.PmtSet.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.PmtSet.FlatAppearance.BorderSize = 0;
            this.PmtSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PmtSet.Font = new System.Drawing.Font("微软雅黑", 6.6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PmtSet.ForeColor = System.Drawing.Color.White;
            this.PmtSet.Location = new System.Drawing.Point(229, 32);
            this.PmtSet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PmtSet.Name = "PmtSet";
            this.PmtSet.Size = new System.Drawing.Size(53, 31);
            this.PmtSet.TabIndex = 20;
            this.PmtSet.Text = "Set";
            this.PmtSet.UseVisualStyleBackColor = false;
            this.PmtSet.Click += new System.EventHandler(this.PmtSet_Click);
            // 
            // PmtSetValue
            // 
            this.PmtSetValue.Increment = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.PmtSetValue.Location = new System.Drawing.Point(109, 31);
            this.PmtSetValue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PmtSetValue.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.PmtSetValue.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.PmtSetValue.Name = "PmtSetValue";
            this.PmtSetValue.Size = new System.Drawing.Size(75, 31);
            this.PmtSetValue.TabIndex = 3;
            this.PmtSetValue.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.PmtSetValue.ValueChanged += new System.EventHandler(this.PmtSetValue_ValueChanged);
            this.PmtSetValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PmtSetValue_KeyDown);
            // 
            // label18
            // 
            this.label18.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label18.Location = new System.Drawing.Point(5, 35);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(133, 25);
            this.label18.TabIndex = 18;
            this.label18.Text = "PMT增益：";
            this.label18.Click += new System.EventHandler(this.label18_Click_1);
            // 
            // label32
            // 
            this.label32.Cursor = System.Windows.Forms.Cursors.Default;
            this.label32.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label32.Location = new System.Drawing.Point(181, 36);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(52, 25);
            this.label32.TabIndex = 22;
            this.label32.Text = "mV";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label17);
            this.groupBox6.Controls.Add(this.dam_thres_interval);
            this.groupBox6.Controls.Add(this.label30);
            this.groupBox6.Controls.Add(this.autoch_thres);
            this.groupBox6.Controls.Add(this.pl_autodam);
            this.groupBox6.Controls.Add(this.autoch_dam);
            this.groupBox6.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox6.Location = new System.Drawing.Point(391, 8);
=======
            this.txRate.Location = new System.Drawing.Point(148, 38);
            this.txRate.Name = "txRate";
            this.txRate.Size = new System.Drawing.Size(143, 33);
            this.txRate.TabIndex = 1;
            // 
            // label25
            // 
            this.label25.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label25.Location = new System.Drawing.Point(5, 38);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(117, 32);
            this.label25.TabIndex = 0;
            this.label25.Text = "发送速率：";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Segoe Print", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(28, 9);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(118, 50);
            this.label26.TabIndex = 1;
            this.label26.Text = "Master";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Location = new System.Drawing.Point(13, 94);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(118, 337);
            this.panel2.TabIndex = 14;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button4.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button4.Image = global::serialDome.Properties.Resources.setting;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button4.Location = new System.Drawing.Point(0, 221);
            this.button4.Margin = new System.Windows.Forms.Padding(0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(116, 108);
            this.button4.TabIndex = 17;
            this.button4.Text = "设置";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button3.Image = global::serialDome.Properties.Resources.master;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.Location = new System.Drawing.Point(0, 111);
            this.button3.Margin = new System.Windows.Forms.Padding(0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(116, 108);
            this.button3.TabIndex = 16;
            this.button3.Text = "从机信息";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Image = global::serialDome.Properties.Resources.master;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 108);
            this.button2.TabIndex = 15;
            this.button2.Text = "主机信息";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pn_set
            // 
            this.pn_set.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_set.Controls.Add(this.groupBox6);
            this.pn_set.Controls.Add(this.groupBox7);
            this.pn_set.Controls.Add(this.groupBox8);
            this.pn_set.Controls.Add(this.groupBox9);
            this.pn_set.Location = new System.Drawing.Point(11, 445);
            this.pn_set.Margin = new System.Windows.Forms.Padding(4);
            this.pn_set.Name = "pn_set";
            this.pn_set.Size = new System.Drawing.Size(774, 277);
            this.pn_set.TabIndex = 15;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.set_rate_r);
            this.groupBox6.Controls.Add(this.set_rate_t);
            this.groupBox6.Controls.Add(this.cancl_rate);
            this.groupBox6.Controls.Add(this.confm_rate);
            this.groupBox6.Controls.Add(this.label28);
            this.groupBox6.Controls.Add(this.label30);
            this.groupBox6.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox6.Location = new System.Drawing.Point(3, 2);
>>>>>>> ecce09b9212c6822719867dd9c3155ebb2e9b5ee
            this.groupBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox6.RightToLeft = System.Windows.Forms.RightToLeft.No;
<<<<<<< HEAD
            this.groupBox6.Size = new System.Drawing.Size(257, 278);
            this.groupBox6.TabIndex = 17;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "衰减片,比较器遍历";
            this.groupBox6.Enter += new System.EventHandler(this.groupBox6_Enter);
            // 
            // label17
            // 
            this.label17.Cursor = System.Windows.Forms.Cursors.Default;
            this.label17.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label17.Location = new System.Drawing.Point(203, 138);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(48, 32);
            this.label17.TabIndex = 44;
            this.label17.Text = "ms";
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // dam_thres_interval
            // 
            this.dam_thres_interval.Location = new System.Drawing.Point(99, 138);
            this.dam_thres_interval.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dam_thres_interval.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.dam_thres_interval.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.dam_thres_interval.Name = "dam_thres_interval";
            this.dam_thres_interval.Size = new System.Drawing.Size(105, 31);
            this.dam_thres_interval.TabIndex = 43;
            this.dam_thres_interval.Value = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.dam_thres_interval.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
=======
            this.groupBox6.Size = new System.Drawing.Size(376, 128);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "信号速率";
            // 
            // set_rate_r
            // 
            this.set_rate_r.Location = new System.Drawing.Point(129, 78);
            this.set_rate_r.Margin = new System.Windows.Forms.Padding(4);
            this.set_rate_r.Name = "set_rate_r";
            this.set_rate_r.Size = new System.Drawing.Size(143, 31);
            this.set_rate_r.TabIndex = 9;
            // 
            // set_rate_t
            // 
            this.set_rate_t.Location = new System.Drawing.Point(129, 36);
            this.set_rate_t.Margin = new System.Windows.Forms.Padding(4);
            this.set_rate_t.Name = "set_rate_t";
            this.set_rate_t.Size = new System.Drawing.Size(143, 31);
            this.set_rate_t.TabIndex = 8;
            // 
            // cancl_rate
            // 
            this.cancl_rate.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.cancl_rate.FlatAppearance.BorderSize = 0;
            this.cancl_rate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancl_rate.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cancl_rate.ForeColor = System.Drawing.Color.White;
            this.cancl_rate.Location = new System.Drawing.Point(292, 80);
            this.cancl_rate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancl_rate.Name = "cancl_rate";
            this.cancl_rate.Size = new System.Drawing.Size(68, 31);
            this.cancl_rate.TabIndex = 5;
            this.cancl_rate.Text = "取消";
            this.cancl_rate.UseVisualStyleBackColor = false;
            // 
            // confm_rate
            // 
            this.confm_rate.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.confm_rate.FlatAppearance.BorderSize = 0;
            this.confm_rate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confm_rate.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.confm_rate.ForeColor = System.Drawing.Color.White;
            this.confm_rate.Location = new System.Drawing.Point(292, 40);
            this.confm_rate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.confm_rate.Name = "confm_rate";
            this.confm_rate.Size = new System.Drawing.Size(68, 31);
            this.confm_rate.TabIndex = 4;
            this.confm_rate.Text = "确定";
            this.confm_rate.UseVisualStyleBackColor = false;
            // 
            // label28
            // 
            this.label28.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label28.Location = new System.Drawing.Point(5, 82);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(117, 32);
            this.label28.TabIndex = 2;
            this.label28.Text = "接收速率：";
>>>>>>> ecce09b9212c6822719867dd9c3155ebb2e9b5ee
            // 
            // label30
            // 
            this.label30.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
<<<<<<< HEAD
            this.label30.Location = new System.Drawing.Point(4, 141);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(205, 32);
            this.label30.TabIndex = 42;
            this.label30.Text = "遍历周期：";
            this.label30.Click += new System.EventHandler(this.label30_Click);
            // 
            // autoch_thres
            // 
            this.autoch_thres.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.autoch_thres.BackColor = System.Drawing.Color.White;
            this.autoch_thres.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.autoch_thres.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.autoch_thres.FlatAppearance.BorderSize = 0;
            this.autoch_thres.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.autoch_thres.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.autoch_thres.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.autoch_thres.Image = ((System.Drawing.Image)(resources.GetObject("autoch_thres.Image")));
            this.autoch_thres.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.autoch_thres.Location = new System.Drawing.Point(3, 229);
            this.autoch_thres.Margin = new System.Windows.Forms.Padding(0);
            this.autoch_thres.Name = "autoch_thres";
            this.autoch_thres.Size = new System.Drawing.Size(248, 35);
            this.autoch_thres.TabIndex = 41;
            this.autoch_thres.Text = "比较器开始遍历";
            this.autoch_thres.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.autoch_thres.UseVisualStyleBackColor = false;
            this.autoch_thres.Click += new System.EventHandler(this.autoch_thres_Click);
            // 
            // pl_autodam
            // 
            this.pl_autodam.Controls.Add(this.dam_end);
            this.pl_autodam.Controls.Add(this.label25);
            this.pl_autodam.Controls.Add(this.label27);
            this.pl_autodam.Controls.Add(this.dam_interval);
            this.pl_autodam.Controls.Add(this.dam_init);
            this.pl_autodam.Controls.Add(this.label20);
            this.pl_autodam.Controls.Add(this.label22);
            this.pl_autodam.Controls.Add(this.label19);
            this.pl_autodam.Controls.Add(this.label21);
            this.pl_autodam.Location = new System.Drawing.Point(5, 26);
            this.pl_autodam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pl_autodam.Name = "pl_autodam";
            this.pl_autodam.Size = new System.Drawing.Size(245, 108);
            this.pl_autodam.TabIndex = 29;
            // 
            // dam_end
            // 
            this.dam_end.DecimalPlaces = 3;
            this.dam_end.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dam_end.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.dam_end.Location = new System.Drawing.Point(60, 70);
            this.dam_end.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dam_end.Maximum = new decimal(new int[] {
            3260,
            0,
            0,
            0});
            this.dam_end.Name = "dam_end";
            this.dam_end.Size = new System.Drawing.Size(131, 31);
            this.dam_end.TabIndex = 38;
            this.dam_end.Value = new decimal(new int[] {
            3260,
            0,
            0,
            0});
            // 
            // label25
            // 
            this.label25.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label25.Location = new System.Drawing.Point(4, 75);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(113, 31);
            this.label25.TabIndex = 36;
            this.label25.Text = "末值";
            // 
            // label27
            // 
            this.label27.Cursor = System.Windows.Forms.Cursors.Default;
            this.label27.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label27.Location = new System.Drawing.Point(185, 72);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(48, 32);
            this.label27.TabIndex = 37;
            this.label27.Text = "mV";
            this.label27.Click += new System.EventHandler(this.label27_Click);
            // 
            // dam_interval
            // 
            this.dam_interval.DecimalPlaces = 3;
            this.dam_interval.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dam_interval.Increment = new decimal(new int[] {
            796,
            0,
            0,
            196608});
            this.dam_interval.Location = new System.Drawing.Point(60, 2);
            this.dam_interval.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dam_interval.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.dam_interval.Name = "dam_interval";
            this.dam_interval.Size = new System.Drawing.Size(131, 31);
            this.dam_interval.TabIndex = 34;
            this.dam_interval.Value = new decimal(new int[] {
            796,
            0,
            0,
            196608});
            // 
            // dam_init
            // 
            this.dam_init.DecimalPlaces = 3;
            this.dam_init.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dam_init.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.dam_init.Location = new System.Drawing.Point(60, 36);
            this.dam_init.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dam_init.Maximum = new decimal(new int[] {
            3260,
            0,
            0,
            0});
            this.dam_init.Name = "dam_init";
            this.dam_init.Size = new System.Drawing.Size(131, 31);
            this.dam_init.TabIndex = 33;
            this.dam_init.Value = new decimal(new int[] {
            3260,
            0,
            0,
            0});
            // 
            // label20
            // 
            this.label20.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label20.Location = new System.Drawing.Point(3, 41);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(113, 31);
            this.label20.TabIndex = 31;
            this.label20.Text = "初值：";
            // 
            // label22
            // 
            this.label22.Cursor = System.Windows.Forms.Cursors.Default;
            this.label22.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label22.Location = new System.Drawing.Point(185, 38);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(48, 32);
            this.label22.TabIndex = 32;
            this.label22.Text = "mV";
            // 
            // label19
            // 
            this.label19.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label19.Location = new System.Drawing.Point(3, 8);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(113, 31);
            this.label19.TabIndex = 29;
            this.label19.Text = "精度：";
            // 
            // label21
            // 
            this.label21.Cursor = System.Windows.Forms.Cursors.Default;
            this.label21.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label21.Location = new System.Drawing.Point(187, 5);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(48, 32);
            this.label21.TabIndex = 30;
            this.label21.Text = "mV";
            // 
            // autoch_dam
            // 
            this.autoch_dam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.autoch_dam.BackColor = System.Drawing.Color.White;
            this.autoch_dam.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.autoch_dam.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.autoch_dam.FlatAppearance.BorderSize = 0;
            this.autoch_dam.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.autoch_dam.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.autoch_dam.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.autoch_dam.Image = ((System.Drawing.Image)(resources.GetObject("autoch_dam.Image")));
            this.autoch_dam.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.autoch_dam.Location = new System.Drawing.Point(3, 184);
            this.autoch_dam.Margin = new System.Windows.Forms.Padding(0);
            this.autoch_dam.Name = "autoch_dam";
            this.autoch_dam.Size = new System.Drawing.Size(245, 35);
            this.autoch_dam.TabIndex = 35;
            this.autoch_dam.Text = "衰减片开始遍历";
            this.autoch_dam.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.autoch_dam.UseVisualStyleBackColor = false;
            this.autoch_dam.Click += new System.EventHandler(this.autoch_dam_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tdd_num);
            this.groupBox4.Controls.Add(this.statu);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.label28);
            this.groupBox4.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox4.Location = new System.Drawing.Point(5, 2);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox4.Size = new System.Drawing.Size(379, 62);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "设备状态";
            // 
            // tdd_num
            // 
            this.tdd_num.BackColor = System.Drawing.Color.White;
            this.tdd_num.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tdd_num.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tdd_num.Location = new System.Drawing.Point(292, 24);
            this.tdd_num.Name = "tdd_num";
            this.tdd_num.Size = new System.Drawing.Size(74, 30);
            this.tdd_num.TabIndex = 6;
            this.tdd_num.Text = "955";
            this.tdd_num.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // statu
            // 
            this.statu.BackColor = System.Drawing.Color.Red;
            this.statu.Font = new System.Drawing.Font("微软雅黑 Light", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.statu.Location = new System.Drawing.Point(100, 22);
            this.statu.Name = "statu";
            this.statu.Size = new System.Drawing.Size(59, 30);
            this.statu.TabIndex = 1;
            this.statu.Text = "断线";
            this.statu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label16.Location = new System.Drawing.Point(5, 26);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(102, 25);
            this.label16.TabIndex = 0;
            this.label16.Text = "通信状态：";
            // 
            // label28
            // 
            this.label28.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label28.Location = new System.Drawing.Point(164, 28);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(176, 32);
            this.label28.TabIndex = 7;
            this.label28.Text = "TDD帧头数量：";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.ThresSet);
            this.groupBox7.Controls.Add(this.txSetValue);
            this.groupBox7.Controls.Add(this.ThresRetn);
            this.groupBox7.Controls.Add(this.thresSetValue);
            this.groupBox7.Controls.Add(this.label8);
            this.groupBox7.Controls.Add(this.TxSet);
            this.groupBox7.Controls.Add(this.label10);
            this.groupBox7.Controls.Add(this.label14);
            this.groupBox7.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox7.Location = new System.Drawing.Point(5, 178);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox7.Size = new System.Drawing.Size(380, 108);
            this.groupBox7.TabIndex = 2;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "电信号参数设置";
            // 
            // ThresSet
            // 
            this.ThresSet.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ThresSet.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ThresSet.FlatAppearance.BorderSize = 0;
            this.ThresSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ThresSet.Font = new System.Drawing.Font("微软雅黑", 6.6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ThresSet.ForeColor = System.Drawing.Color.White;
            this.ThresSet.Location = new System.Drawing.Point(275, 70);
            this.ThresSet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ThresSet.Name = "ThresSet";
            this.ThresSet.Size = new System.Drawing.Size(53, 31);
            this.ThresSet.TabIndex = 8;
            this.ThresSet.Text = "Set";
            this.ThresSet.UseVisualStyleBackColor = false;
            this.ThresSet.Click += new System.EventHandler(this.ThresSet_Click);
            // 
            // txSetValue
            // 
            this.txSetValue.Cursor = System.Windows.Forms.Cursors.Default;
            this.txSetValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txSetValue.FormattingEnabled = true;
            this.txSetValue.Items.AddRange(new object[] {
            "6.25MHz",
            "12.5MHz",
            "25MHz"});
            this.txSetValue.Location = new System.Drawing.Point(124, 26);
            this.txSetValue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txSetValue.Name = "txSetValue";
            this.txSetValue.Size = new System.Drawing.Size(143, 33);
            this.txSetValue.TabIndex = 8;
            this.txSetValue.SelectedIndexChanged += new System.EventHandler(this.txSetValue_SelectedIndexChanged);
            // 
            // ThresRetn
            // 
            this.ThresRetn.BackColor = System.Drawing.Color.FloralWhite;
            this.ThresRetn.FlatAppearance.BorderSize = 0;
            this.ThresRetn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ThresRetn.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ThresRetn.ForeColor = System.Drawing.Color.White;
            this.ThresRetn.Image = ((System.Drawing.Image)(resources.GetObject("ThresRetn.Image")));
            this.ThresRetn.Location = new System.Drawing.Point(327, 70);
            this.ThresRetn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ThresRetn.Name = "ThresRetn";
            this.ThresRetn.Size = new System.Drawing.Size(36, 31);
            this.ThresRetn.TabIndex = 14;
            this.ThresRetn.UseVisualStyleBackColor = false;
            this.ThresRetn.Click += new System.EventHandler(this.ThresRetn_Click);
            // 
            // thresSetValue
            // 
            this.thresSetValue.DecimalPlaces = 3;
            this.thresSetValue.Increment = new decimal(new int[] {
            796,
            0,
            0,
            196608});
            this.thresSetValue.Location = new System.Drawing.Point(124, 68);
            this.thresSetValue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.thresSetValue.Maximum = new decimal(new int[] {
            3260,
            0,
            0,
            0});
            this.thresSetValue.Name = "thresSetValue";
            this.thresSetValue.Size = new System.Drawing.Size(115, 31);
            this.thresSetValue.TabIndex = 2;
            this.thresSetValue.Value = new decimal(new int[] {
            796,
            0,
            0,
            0});
            this.thresSetValue.ValueChanged += new System.EventHandler(this.thresSetValue_ValueChanged);
            this.thresSetValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.thresSetValue_KeyDown);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(5, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 25);
            this.label8.TabIndex = 2;
            this.label8.Text = "比较器阈值：";
            // 
            // TxSet
            // 
            this.TxSet.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.TxSet.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TxSet.FlatAppearance.BorderSize = 0;
            this.TxSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TxSet.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TxSet.ForeColor = System.Drawing.Color.White;
            this.TxSet.Location = new System.Drawing.Point(275, 26);
            this.TxSet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxSet.Name = "TxSet";
            this.TxSet.Size = new System.Drawing.Size(85, 31);
            this.TxSet.TabIndex = 4;
            this.TxSet.Text = "确定";
            this.TxSet.UseVisualStyleBackColor = false;
            this.TxSet.Click += new System.EventHandler(this.TxSet_Click);
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(7, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 32);
            this.label10.TabIndex = 0;
            this.label10.Text = "传输速率：";
            this.label10.Click += new System.EventHandler(this.label10_Click_1);
            // 
            // label14
            // 
            this.label14.Cursor = System.Windows.Forms.Cursors.Default;
            this.label14.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.Location = new System.Drawing.Point(235, 69);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 25);
            this.label14.TabIndex = 17;
            this.label14.Text = "mV";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.DampingSet);
            this.groupBox5.Controls.Add(this.PmtRetn);
            this.groupBox5.Controls.Add(this.PWSet);
            this.groupBox5.Controls.Add(this.pwSetValue);
            this.groupBox5.Controls.Add(this.damSetValue);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox5.Location = new System.Drawing.Point(5, 68);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox5.Size = new System.Drawing.Size(376, 106);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "信道光信号参数设置";
            // 
            // DampingSet
            // 
            this.DampingSet.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.DampingSet.FlatAppearance.BorderSize = 0;
            this.DampingSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DampingSet.Font = new System.Drawing.Font("微软雅黑", 6.6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DampingSet.ForeColor = System.Drawing.Color.White;
            this.DampingSet.Location = new System.Drawing.Point(275, 66);
            this.DampingSet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DampingSet.Name = "DampingSet";
            this.DampingSet.Size = new System.Drawing.Size(49, 31);
            this.DampingSet.TabIndex = 16;
            this.DampingSet.Text = "Set";
            this.DampingSet.UseMnemonic = false;
            this.DampingSet.UseVisualStyleBackColor = false;
            this.DampingSet.Click += new System.EventHandler(this.DampingSet_Click);
            // 
            // PmtRetn
            // 
            this.PmtRetn.BackColor = System.Drawing.Color.FloralWhite;
            this.PmtRetn.FlatAppearance.BorderSize = 0;
            this.PmtRetn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PmtRetn.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PmtRetn.ForeColor = System.Drawing.Color.White;
            this.PmtRetn.Image = ((System.Drawing.Image)(resources.GetObject("PmtRetn.Image")));
            this.PmtRetn.Location = new System.Drawing.Point(323, 66);
            this.PmtRetn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PmtRetn.Name = "PmtRetn";
            this.PmtRetn.Size = new System.Drawing.Size(36, 31);
            this.PmtRetn.TabIndex = 17;
            this.PmtRetn.Text = "←";
            this.PmtRetn.UseVisualStyleBackColor = false;
            this.PmtRetn.Click += new System.EventHandler(this.PmtRetn_Click);
            // 
            // PWSet
            // 
            this.PWSet.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.PWSet.FlatAppearance.BorderSize = 0;
            this.PWSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PWSet.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PWSet.ForeColor = System.Drawing.Color.White;
            this.PWSet.Location = new System.Drawing.Point(275, 26);
            this.PWSet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PWSet.Name = "PWSet";
            this.PWSet.Size = new System.Drawing.Size(85, 31);
            this.PWSet.TabIndex = 15;
            this.PWSet.Text = "确定";
            this.PWSet.UseVisualStyleBackColor = false;
            this.PWSet.Click += new System.EventHandler(this.PWSet_Click);
            // 
            // pwSetValue
            // 
            this.pwSetValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pwSetValue.FormattingEnabled = true;
            this.pwSetValue.Items.AddRange(new object[] {
            "全部关闭",
            "散光",
            "汇聚光",
            "全部开启"});
            this.pwSetValue.Location = new System.Drawing.Point(124, 26);
            this.pwSetValue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pwSetValue.Name = "pwSetValue";
            this.pwSetValue.Size = new System.Drawing.Size(143, 33);
            this.pwSetValue.TabIndex = 7;
            // 
            // damSetValue
            // 
            this.damSetValue.DecimalPlaces = 3;
            this.damSetValue.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.damSetValue.Location = new System.Drawing.Point(124, 66);
            this.damSetValue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.damSetValue.Maximum = new decimal(new int[] {
            3260,
            0,
            0,
            0});
            this.damSetValue.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.damSetValue.Name = "damSetValue";
            this.damSetValue.Size = new System.Drawing.Size(117, 31);
            this.damSetValue.TabIndex = 1;
            this.damSetValue.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.damSetValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.damSetValue_KeyDown);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(5, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "衰减片电压：";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(5, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 32);
            this.label4.TabIndex = 0;
            this.label4.Text = "激光器模式：";
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(237, 68);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 32);
            this.label12.TabIndex = 14;
            this.label12.Text = "mV";
            // 
            // reset
            // 
            this.reset.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.reset.FlatAppearance.BorderSize = 0;
            this.reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reset.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.reset.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.reset.Location = new System.Drawing.Point(616, 36);
            this.reset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(107, 39);
            this.reset.TabIndex = 10;
            this.reset.Text = "复位";
            this.reset.UseVisualStyleBackColor = false;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 26);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 62);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(21, 184);
            this.label31.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(202, 26);
            this.label31.TabIndex = 25;
            this.label31.Text = "自动保存数据表命名：";
            this.label31.Click += new System.EventHandler(this.label31_Click);
            // 
            // DataTableName
            // 
            this.DataTableName.AcceptsReturn = true;
            this.DataTableName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataTableName.Font = new System.Drawing.Font("微软雅黑 Light", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DataTableName.Location = new System.Drawing.Point(0, 0);
            this.DataTableName.Margin = new System.Windows.Forms.Padding(4);
            this.DataTableName.Multiline = true;
            this.DataTableName.Name = "DataTableName";
            this.DataTableName.Size = new System.Drawing.Size(300, 71);
            this.DataTableName.TabIndex = 13;
            this.DataTableName.Text = "默认命名为“MMdd - HHmm自动保存数据表”";
            this.DataTableName.TextChanged += new System.EventHandler(this.textBox1_TextChanged_2);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.DataTableName);
            this.panel4.Location = new System.Drawing.Point(27, 209);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(300, 71);
            this.panel4.TabIndex = 26;
            // 
            // groupBox15
            // 
            this.groupBox15.Controls.Add(this.isPPM);
            this.groupBox15.Controls.Add(this.isOOK);
            this.groupBox15.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox15.Location = new System.Drawing.Point(394, 290);
=======
            this.label30.Location = new System.Drawing.Point(5, 38);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(117, 32);
            this.label30.TabIndex = 0;
            this.label30.Text = "发送速率：";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.cancl_set);
            this.groupBox7.Controls.Add(this.confm_set);
            this.groupBox7.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox7.Location = new System.Drawing.Point(393, 172);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox7.Size = new System.Drawing.Size(356, 90);
            this.groupBox7.TabIndex = 7;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "确定设置";
            // 
            // cancl_set
            // 
            this.cancl_set.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.cancl_set.FlatAppearance.BorderSize = 0;
            this.cancl_set.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancl_set.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cancl_set.ForeColor = System.Drawing.Color.White;
            this.cancl_set.Location = new System.Drawing.Point(192, 52);
            this.cancl_set.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancl_set.Name = "cancl_set";
            this.cancl_set.Size = new System.Drawing.Size(97, 31);
            this.cancl_set.TabIndex = 6;
            this.cancl_set.Text = "取消";
            this.cancl_set.UseVisualStyleBackColor = false;
            // 
            // confm_set
            // 
            this.confm_set.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.confm_set.FlatAppearance.BorderSize = 0;
            this.confm_set.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confm_set.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.confm_set.ForeColor = System.Drawing.Color.White;
            this.confm_set.Location = new System.Drawing.Point(56, 52);
            this.confm_set.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.confm_set.Name = "confm_set";
            this.confm_set.Size = new System.Drawing.Size(97, 31);
            this.confm_set.TabIndex = 5;
            this.confm_set.Text = "确定";
            this.confm_set.UseVisualStyleBackColor = false;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.set_dis);
            this.groupBox8.Controls.Add(this.concl_dis);
            this.groupBox8.Controls.Add(this.confm_dis);
            this.groupBox8.Controls.Add(this.label32);
            this.groupBox8.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox8.Location = new System.Drawing.Point(3, 135);
            this.groupBox8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox8.Size = new System.Drawing.Size(376, 128);
            this.groupBox8.TabIndex = 2;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "分辨率";
            // 
            // set_dis
            // 
            this.set_dis.Location = new System.Drawing.Point(191, 31);
            this.set_dis.Margin = new System.Windows.Forms.Padding(4);
            this.set_dis.Name = "set_dis";
            this.set_dis.Size = new System.Drawing.Size(168, 31);
            this.set_dis.TabIndex = 9;
            // 
            // concl_dis
            // 
            this.concl_dis.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.concl_dis.FlatAppearance.BorderSize = 0;
            this.concl_dis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.concl_dis.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.concl_dis.ForeColor = System.Drawing.Color.White;
            this.concl_dis.Location = new System.Drawing.Point(205, 80);
            this.concl_dis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.concl_dis.Name = "concl_dis";
            this.concl_dis.Size = new System.Drawing.Size(68, 31);
            this.concl_dis.TabIndex = 5;
            this.concl_dis.Text = "取消";
            this.concl_dis.UseVisualStyleBackColor = false;
            // 
            // confm_dis
            // 
            this.confm_dis.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.confm_dis.FlatAppearance.BorderSize = 0;
            this.confm_dis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confm_dis.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.confm_dis.ForeColor = System.Drawing.Color.White;
            this.confm_dis.Location = new System.Drawing.Point(101, 80);
            this.confm_dis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.confm_dis.Name = "confm_dis";
            this.confm_dis.Size = new System.Drawing.Size(68, 31);
            this.confm_dis.TabIndex = 4;
            this.confm_dis.Text = "确定";
            this.confm_dis.UseVisualStyleBackColor = false;
            // 
            // label32
            // 
            this.label32.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label32.Location = new System.Drawing.Point(5, 38);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(204, 32);
            this.label32.TabIndex = 0;
            this.label32.Text = "云台扫描分辨率：";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.set_rate);
            this.groupBox9.Controls.Add(this.set_ratio);
            this.groupBox9.Controls.Add(this.cancl_tdd);
            this.groupBox9.Controls.Add(this.confm_tdd);
            this.groupBox9.Controls.Add(this.label34);
            this.groupBox9.Controls.Add(this.label36);
            this.groupBox9.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox9.Location = new System.Drawing.Point(393, 12);
            this.groupBox9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox9.Size = new System.Drawing.Size(356, 152);
            this.groupBox9.TabIndex = 3;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "TDD模式";
            // 
            // set_rate
            // 
            this.set_rate.Location = new System.Drawing.Point(131, 68);
            this.set_rate.Margin = new System.Windows.Forms.Padding(4);
            this.set_rate.Name = "set_rate";
            this.set_rate.Size = new System.Drawing.Size(143, 31);
            this.set_rate.TabIndex = 7;
            // 
            // set_ratio
            // 
            this.set_ratio.Location = new System.Drawing.Point(131, 28);
            this.set_ratio.Margin = new System.Windows.Forms.Padding(4);
            this.set_ratio.Name = "set_ratio";
            this.set_ratio.Size = new System.Drawing.Size(143, 31);
            this.set_ratio.TabIndex = 6;
            // 
            // cancl_tdd
            // 
            this.cancl_tdd.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.cancl_tdd.FlatAppearance.BorderSize = 0;
            this.cancl_tdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancl_tdd.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cancl_tdd.ForeColor = System.Drawing.Color.White;
            this.cancl_tdd.Location = new System.Drawing.Point(205, 109);
            this.cancl_tdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancl_tdd.Name = "cancl_tdd";
            this.cancl_tdd.Size = new System.Drawing.Size(68, 31);
            this.cancl_tdd.TabIndex = 5;
            this.cancl_tdd.Text = "取消";
            this.cancl_tdd.UseVisualStyleBackColor = false;
            // 
            // confm_tdd
            // 
            this.confm_tdd.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.confm_tdd.FlatAppearance.BorderSize = 0;
            this.confm_tdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confm_tdd.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.confm_tdd.ForeColor = System.Drawing.Color.White;
            this.confm_tdd.Location = new System.Drawing.Point(56, 109);
            this.confm_tdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.confm_tdd.Name = "confm_tdd";
            this.confm_tdd.Size = new System.Drawing.Size(68, 31);
            this.confm_tdd.TabIndex = 4;
            this.confm_tdd.Text = "确定";
            this.confm_tdd.UseVisualStyleBackColor = false;
            // 
            // label34
            // 
            this.label34.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label34.Location = new System.Drawing.Point(5, 68);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(117, 32);
            this.label34.TabIndex = 2;
            this.label34.Text = "码率：";
            // 
            // label36
            // 
            this.label36.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label36.Location = new System.Drawing.Point(5, 29);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(117, 32);
            this.label36.TabIndex = 0;
            this.label36.Text = "时隙比：";
            // 
            // pn_slave
            // 
            this.pn_slave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_slave.Controls.Add(this.label1);
            this.pn_slave.Controls.Add(this.button13);
            this.pn_slave.Controls.Add(this.groupBox10);
            this.pn_slave.Controls.Add(this.panel6);
            this.pn_slave.Controls.Add(this.groupBox11);
            this.pn_slave.Controls.Add(this.groupBox12);
            this.pn_slave.Controls.Add(this.groupBox13);
            this.pn_slave.Controls.Add(this.groupBox14);
            this.pn_slave.Controls.Add(this.groupBox15);
            this.pn_slave.Location = new System.Drawing.Point(805, 445);
            this.pn_slave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pn_slave.Name = "pn_slave";
            this.pn_slave.Size = new System.Drawing.Size(1231, 337);
            this.pn_slave.TabIndex = 15;
            this.pn_slave.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 50);
            this.label1.TabIndex = 10;
            this.label1.Text = "Slave";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button13.FlatAppearance.BorderSize = 0;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button13.Location = new System.Drawing.Point(480, 16);
            this.button13.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(113, 38);
            this.button13.TabIndex = 9;
            this.button13.Text = "复位";
            this.button13.UseVisualStyleBackColor = false;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.textBox7);
            this.groupBox10.Controls.Add(this.textBox8);
            this.groupBox10.Controls.Add(this.label37);
            this.groupBox10.Controls.Add(this.label38);
            this.groupBox10.Controls.Add(this.textBox9);
            this.groupBox10.Controls.Add(this.textBox10);
            this.groupBox10.Controls.Add(this.label39);
            this.groupBox10.Controls.Add(this.label40);
            this.groupBox10.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox10.Location = new System.Drawing.Point(620, 10);
            this.groupBox10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox10.Size = new System.Drawing.Size(603, 119);
            this.groupBox10.TabIndex = 8;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "TDD帧结构";
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox7.Location = new System.Drawing.Point(419, 74);
            this.textBox7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(165, 31);
            this.textBox7.TabIndex = 13;
            // 
            // textBox8
            // 
            this.textBox8.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox8.Location = new System.Drawing.Point(419, 30);
            this.textBox8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(165, 31);
            this.textBox8.TabIndex = 12;
            // 
            // label37
            // 
            this.label37.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label37.Location = new System.Drawing.Point(293, 75);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(143, 32);
            this.label37.TabIndex = 11;
            this.label37.Text = "调制格式：";
            // 
            // label38
            // 
            this.label38.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label38.Location = new System.Drawing.Point(293, 40);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(143, 32);
            this.label38.TabIndex = 10;
            this.label38.Text = "码率：";
            // 
            // textBox9
            // 
            this.textBox9.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox9.Location = new System.Drawing.Point(137, 75);
            this.textBox9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(139, 31);
            this.textBox9.TabIndex = 9;
            // 
            // textBox10
            // 
            this.textBox10.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox10.Location = new System.Drawing.Point(137, 36);
            this.textBox10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(139, 31);
            this.textBox10.TabIndex = 8;
            // 
            // label39
            // 
            this.label39.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label39.Location = new System.Drawing.Point(5, 72);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(143, 32);
            this.label39.TabIndex = 6;
            this.label39.Text = "当前时隙比：";
            // 
            // label40
            // 
            this.label40.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label40.Location = new System.Drawing.Point(5, 36);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(143, 32);
            this.label40.TabIndex = 4;
            this.label40.Text = "帧类型：";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label41);
            this.panel6.Controls.Add(this.label42);
            this.panel6.Location = new System.Drawing.Point(220, 10);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(164, 44);
            this.panel6.TabIndex = 6;
            // 
            // label41
            // 
            this.label41.BackColor = System.Drawing.SystemColors.Control;
            this.label41.Font = new System.Drawing.Font("微软雅黑 Light", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label41.Location = new System.Drawing.Point(104, 8);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(59, 22);
            this.label41.TabIndex = 1;
            this.label41.Text = "断线";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label42.Location = new System.Drawing.Point(3, 6);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(107, 26);
            this.label42.TabIndex = 0;
            this.label42.Text = "通信状态：";
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.textBox11);
            this.groupBox11.Controls.Add(this.textBox12);
            this.groupBox11.Controls.Add(this.label43);
            this.groupBox11.Controls.Add(this.label44);
            this.groupBox11.Controls.Add(this.panel7);
            this.groupBox11.Controls.Add(this.label45);
            this.groupBox11.Controls.Add(this.chart2);
            this.groupBox11.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox11.Location = new System.Drawing.Point(620, 135);
            this.groupBox11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox11.Size = new System.Drawing.Size(603, 186);
            this.groupBox11.TabIndex = 5;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "云台控制";
            // 
            // textBox11
            // 
            this.textBox11.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox11.Location = new System.Drawing.Point(148, 132);
            this.textBox11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(139, 31);
            this.textBox11.TabIndex = 9;
            // 
            // textBox12
            // 
            this.textBox12.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox12.Location = new System.Drawing.Point(148, 91);
            this.textBox12.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(139, 31);
            this.textBox12.TabIndex = 8;
            // 
            // label43
            // 
            this.label43.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label43.Location = new System.Drawing.Point(5, 135);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(143, 32);
            this.label43.TabIndex = 6;
            this.label43.Text = "云台水平角：";
            // 
            // label44
            // 
            this.label44.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label44.Location = new System.Drawing.Point(5, 91);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(143, 32);
            this.label44.TabIndex = 4;
            this.label44.Text = "云台俯仰角：";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.radioButton1);
            this.panel7.Controls.Add(this.radioButton2);
            this.panel7.Location = new System.Drawing.Point(148, 42);
            this.panel7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(140, 38);
            this.panel7.TabIndex = 0;
            // 
            // radioButton1
            // 
            this.radioButton1.Checked = true;
            this.radioButton1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton1.Location = new System.Drawing.Point(65, 2);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(75, 34);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "自动";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton2.Location = new System.Drawing.Point(3, 1);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(68, 34);
            this.radioButton2.TabIndex = 0;
            this.radioButton2.Text = "手动";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // label45
            // 
            this.label45.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label45.Location = new System.Drawing.Point(5, 48);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(157, 32);
            this.label45.TabIndex = 1;
            this.label45.Text = "对准模式：";
            // 
            // chart2
            // 
            chartArea2.AxisX.LabelStyle.Enabled = false;
            chartArea2.AxisX.MajorGrid.Enabled = false;
            chartArea2.AxisY.MajorGrid.Enabled = false;
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(272, 15);
            this.chart2.Margin = new System.Windows.Forms.Padding(4);
            this.chart2.Name = "chart2";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "P";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(323, 165);
            this.chart2.TabIndex = 10;
            this.chart2.Text = "chart2";
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.label46);
            this.groupBox12.Controls.Add(this.label47);
            this.groupBox12.Controls.Add(this.label48);
            this.groupBox12.Controls.Add(this.label49);
            this.groupBox12.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox12.Location = new System.Drawing.Point(3, 198);
            this.groupBox12.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox12.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox12.Size = new System.Drawing.Size(299, 124);
            this.groupBox12.TabIndex = 4;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "信道误码";
            // 
            // label46
            // 
            this.label46.BackColor = System.Drawing.Color.White;
            this.label46.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label46.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label46.Location = new System.Drawing.Point(148, 82);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(139, 33);
            this.label46.TabIndex = 3;
            // 
            // label47
            // 
            this.label47.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label47.Location = new System.Drawing.Point(5, 82);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(157, 32);
            this.label47.TabIndex = 2;
            this.label47.Text = "误码数据量：";
            // 
            // label48
            // 
            this.label48.BackColor = System.Drawing.Color.White;
            this.label48.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label48.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label48.Location = new System.Drawing.Point(148, 38);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(139, 33);
            this.label48.TabIndex = 1;
            this.label48.Text = "1e-6";
            // 
            // label49
            // 
            this.label49.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label49.Location = new System.Drawing.Point(5, 38);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(143, 32);
            this.label49.TabIndex = 0;
            this.label49.Text = "误码率：";
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.label50);
            this.groupBox13.Controls.Add(this.label51);
            this.groupBox13.Controls.Add(this.label52);
            this.groupBox13.Controls.Add(this.label53);
            this.groupBox13.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox13.Location = new System.Drawing.Point(316, 198);
            this.groupBox13.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox13.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox13.Size = new System.Drawing.Size(299, 124);
            this.groupBox13.TabIndex = 3;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "信道光信号";
            // 
            // label50
            // 
            this.label50.BackColor = System.Drawing.Color.White;
            this.label50.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label50.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label50.Location = new System.Drawing.Point(148, 81);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(143, 33);
            this.label50.TabIndex = 3;
            // 
            // label51
            // 
            this.label51.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label51.Location = new System.Drawing.Point(5, 82);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(136, 32);
            this.label51.TabIndex = 2;
            this.label51.Text = "PMT灵敏度：";
            // 
            // label52
            // 
            this.label52.BackColor = System.Drawing.Color.White;
            this.label52.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label52.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label52.Location = new System.Drawing.Point(148, 38);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(143, 33);
            this.label52.TabIndex = 1;
            // 
            // label53
            // 
            this.label53.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label53.Location = new System.Drawing.Point(5, 38);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(136, 32);
            this.label53.TabIndex = 0;
            this.label53.Text = "光功率强度：";
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.label54);
            this.groupBox14.Controls.Add(this.label55);
            this.groupBox14.Controls.Add(this.label56);
            this.groupBox14.Controls.Add(this.label57);
            this.groupBox14.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox14.Location = new System.Drawing.Point(3, 66);
            this.groupBox14.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox14.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox14.Size = new System.Drawing.Size(299, 125);
            this.groupBox14.TabIndex = 2;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "数据吞吐量";
            // 
            // label54
            // 
            this.label54.BackColor = System.Drawing.Color.White;
            this.label54.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label54.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label54.Location = new System.Drawing.Point(149, 81);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(139, 33);
            this.label54.TabIndex = 3;
            this.label54.Text = "111";
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label55.Location = new System.Drawing.Point(5, 82);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(107, 25);
            this.label55.TabIndex = 2;
            this.label55.Text = "接收总量：";
            // 
            // label56
            // 
            this.label56.BackColor = System.Drawing.Color.White;
            this.label56.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label56.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label56.Location = new System.Drawing.Point(148, 38);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(139, 33);
            this.label56.TabIndex = 1;
            this.label56.Text = "1234567MB";
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label57.Location = new System.Drawing.Point(5, 38);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(107, 25);
            this.label57.TabIndex = 0;
            this.label57.Text = "发送总量：";
            // 
            // groupBox15
            // 
            this.groupBox15.Controls.Add(this.label58);
            this.groupBox15.Controls.Add(this.label59);
            this.groupBox15.Controls.Add(this.label60);
            this.groupBox15.Controls.Add(this.label61);
            this.groupBox15.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox15.Location = new System.Drawing.Point(316, 66);
>>>>>>> ecce09b9212c6822719867dd9c3155ebb2e9b5ee
            this.groupBox15.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox15.RightToLeft = System.Windows.Forms.RightToLeft.No;
<<<<<<< HEAD
            this.groupBox15.Size = new System.Drawing.Size(254, 74);
            this.groupBox15.TabIndex = 19;
            this.groupBox15.TabStop = false;
            this.groupBox15.Text = "当前调制方式";
            // 
            // isOOK
            // 
            this.isOOK.AutoSize = true;
            this.isOOK.Checked = true;
            this.isOOK.Location = new System.Drawing.Point(11, 31);
            this.isOOK.Name = "isOOK";
            this.isOOK.Size = new System.Drawing.Size(78, 30);
            this.isOOK.TabIndex = 0;
            this.isOOK.TabStop = true;
            this.isOOK.Text = "OOK";
            this.isOOK.UseVisualStyleBackColor = true;
            this.isOOK.EnabledChanged += new System.EventHandler(this.isOOK_EnabledChanged);
            this.isOOK.MouseClick += new System.Windows.Forms.MouseEventHandler(this.isOOK_MouseClick);
            // 
            // isPPM
            // 
            this.isPPM.AutoSize = true;
            this.isPPM.Location = new System.Drawing.Point(129, 30);
            this.isPPM.Name = "isPPM";
            this.isPPM.Size = new System.Drawing.Size(77, 30);
            this.isPPM.TabIndex = 1;
            this.isPPM.Text = "PPM";
            this.isPPM.UseVisualStyleBackColor = true;
            this.isPPM.Click += new System.EventHandler(this.isPPM_Click);
=======
            this.groupBox15.Size = new System.Drawing.Size(299, 125);
            this.groupBox15.TabIndex = 0;
            this.groupBox15.TabStop = false;
            this.groupBox15.Text = "信号速率";
            // 
            // label58
            // 
            this.label58.BackColor = System.Drawing.Color.White;
            this.label58.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label58.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label58.Location = new System.Drawing.Point(148, 81);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(143, 33);
            this.label58.TabIndex = 3;
            // 
            // label59
            // 
            this.label59.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label59.Location = new System.Drawing.Point(5, 82);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(117, 32);
            this.label59.TabIndex = 2;
            this.label59.Text = "接收速率：";
            // 
            // label60
            // 
            this.label60.BackColor = System.Drawing.Color.White;
            this.label60.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label60.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label60.Location = new System.Drawing.Point(148, 38);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(143, 33);
            this.label60.TabIndex = 1;
            // 
            // label61
            // 
            this.label61.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label61.Location = new System.Drawing.Point(5, 38);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(117, 32);
            this.label61.TabIndex = 0;
            this.label61.Text = "发送速率：";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::serialDome.Properties.Resources.logo1;
            this.pictureBox1.Location = new System.Drawing.Point(597, 14);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 62);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
>>>>>>> ecce09b9212c6822719867dd9c3155ebb2e9b5ee
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
<<<<<<< HEAD
            this.ClientSize = new System.Drawing.Size(1123, 729);
            this.Controls.Add(this.groupBox10);
            this.Controls.Add(this.pn_master);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.reset);
=======
            this.ClientSize = new System.Drawing.Size(1411, 496);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pn_master);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.pn_set);
            this.Controls.Add(this.pn_slave);
>>>>>>> ecce09b9212c6822719867dd9c3155ebb2e9b5ee
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(20, 75, 20, 20);
<<<<<<< HEAD
=======
            this.Text = "      信息监测";
>>>>>>> ecce09b9212c6822719867dd9c3155ebb2e9b5ee
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.TransparencyKey = System.Drawing.Color.Ivory;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.pn_master.ResumeLayout(false);
<<<<<<< HEAD
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.save_interval)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox14.ResumeLayout(false);
            this.groupBox13.ResumeLayout(false);
            this.groupBox12.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gb1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PmtSetValue)).EndInit();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dam_thres_interval)).EndInit();
            this.pl_autodam.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dam_end)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dam_interval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dam_init)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.thresSetValue)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.damSetValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.groupBox15.ResumeLayout(false);
            this.groupBox15.PerformLayout();
=======
            this.pn_master.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gb1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.pn_set.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.pn_slave.ResumeLayout(false);
            this.pn_slave.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.groupBox12.ResumeLayout(false);
            this.groupBox13.ResumeLayout(false);
            this.groupBox14.ResumeLayout(false);
            this.groupBox14.PerformLayout();
            this.groupBox15.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
>>>>>>> ecce09b9212c6822719867dd9c3155ebb2e9b5ee
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
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label ber_cn;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label ber;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label damping;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label power;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label cn_rx;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label cn_tx;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.GroupBox gb1;
		private System.Windows.Forms.Label thres;
		private System.Windows.Forms.Label txRate;
		private System.Windows.Forms.Button reset;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox txSetValue;
        private System.Windows.Forms.ComboBox pwSetValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.NumericUpDown thresSetValue;
        private System.Windows.Forms.NumericUpDown damSetValue;
        private System.Windows.Forms.Button TxSet;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button ThresRetn;
        private System.Windows.Forms.Button ThresSet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button DampingSet;
        private System.Windows.Forms.Button PmtRetn;
        private System.Windows.Forms.Button PWSet;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button ch_ms;
        private System.Windows.Forms.Label statu_ms;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label statu;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label rx_power;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Button save_data;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label filepath;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button change_file;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.NumericUpDown save_interval;
        private System.Windows.Forms.Button auto_save;
        private System.Windows.Forms.Label tdd_num;
        private System.Windows.Forms.Panel pl_autodam;
        private System.Windows.Forms.NumericUpDown dam_end;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Button autoch_dam;
        private System.Windows.Forms.NumericUpDown dam_interval;
        private System.Windows.Forms.NumericUpDown dam_init;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Button autoch_thres;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.Button PmtSave;
        private System.Windows.Forms.Button PmtSet;
        private System.Windows.Forms.NumericUpDown PmtSetValue;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.Label rx_hum;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label rx_tem;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.Label pmt;
        private System.Windows.Forms.Label pmt_init;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox14;
        private System.Windows.Forms.Label tx_hum;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label tx_tem;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.TextBox LightPower;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.NumericUpDown dam_thres_interval;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox DataTableName;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox groupBox15;
        private System.Windows.Forms.RadioButton isPPM;
        private System.Windows.Forms.RadioButton isOOK;
    }
}

