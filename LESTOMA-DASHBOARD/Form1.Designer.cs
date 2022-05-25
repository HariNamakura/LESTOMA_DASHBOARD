
namespace LESTOMA_DASHBOARD
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title6 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title7 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title8 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend9 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title9 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend10 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title10 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_BaudRate = new System.Windows.Forms.ComboBox();
            this.comboBox_PortList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSensors = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.chartTemp = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartHum = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartWindDir = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartRain = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartWindSpd = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnRain = new System.Windows.Forms.Button();
            this.btnWindDirection = new System.Windows.Forms.Button();
            this.btnWindSpd = new System.Windows.Forms.Button();
            this.btnHumidity = new System.Windows.Forms.Button();
            this.btnTemp = new System.Windows.Forms.Button();
            this.lblWindSpeed = new System.Windows.Forms.Label();
            this.lblHumidity = new System.Windows.Forms.Label();
            this.lblTemp = new System.Windows.Forms.Label();
            this.lblRainFall = new System.Windows.Forms.Label();
            this.lblWindDir = new System.Windows.Forms.Label();
            this.panelSideMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTemp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartHum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartWindDir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartWindSpd)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.Gainsboro;
            this.panelSideMenu.Controls.Add(this.btnRain);
            this.panelSideMenu.Controls.Add(this.btnWindDirection);
            this.panelSideMenu.Controls.Add(this.btnWindSpd);
            this.panelSideMenu.Controls.Add(this.btnHumidity);
            this.panelSideMenu.Controls.Add(this.btnTemp);
            this.panelSideMenu.Controls.Add(this.panel1);
            this.panelSideMenu.Controls.Add(this.btnSensors);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(250, 492);
            this.panelSideMenu.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnOpen);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.comboBox_BaudRate);
            this.panel1.Controls.Add(this.comboBox_PortList);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 350);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 130);
            this.panel1.TabIndex = 2;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.DarkGray;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(134, 96);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(90, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "CLOSE";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.BackColor = System.Drawing.Color.DarkGray;
            this.btnOpen.FlatAppearance.BorderSize = 0;
            this.btnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpen.Location = new System.Drawing.Point(21, 96);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(94, 23);
            this.btnOpen.TabIndex = 3;
            this.btnOpen.Text = "OPEN";
            this.btnOpen.UseVisualStyleBackColor = false;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "BAUD RATE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "COM PORT";
            // 
            // comboBox_BaudRate
            // 
            this.comboBox_BaudRate.BackColor = System.Drawing.Color.DarkGray;
            this.comboBox_BaudRate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_BaudRate.FormattingEnabled = true;
            this.comboBox_BaudRate.Items.AddRange(new object[] {
            "9600",
            "38400",
            "57600",
            "115200"});
            this.comboBox_BaudRate.Location = new System.Drawing.Point(114, 63);
            this.comboBox_BaudRate.Name = "comboBox_BaudRate";
            this.comboBox_BaudRate.Size = new System.Drawing.Size(110, 24);
            this.comboBox_BaudRate.TabIndex = 2;
            this.comboBox_BaudRate.Text = "9600";
            // 
            // comboBox_PortList
            // 
            this.comboBox_PortList.BackColor = System.Drawing.Color.DarkGray;
            this.comboBox_PortList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_PortList.FormattingEnabled = true;
            this.comboBox_PortList.Location = new System.Drawing.Point(114, 33);
            this.comboBox_PortList.Name = "comboBox_PortList";
            this.comboBox_PortList.Size = new System.Drawing.Size(110, 24);
            this.comboBox_PortList.TabIndex = 2;
            this.comboBox_PortList.DropDown += new System.EventHandler(this.comboBox_PortList_DropDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "COM PORT SETTINGS";
            // 
            // btnSensors
            // 
            this.btnSensors.BackColor = System.Drawing.Color.DarkGray;
            this.btnSensors.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSensors.FlatAppearance.BorderSize = 0;
            this.btnSensors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSensors.ForeColor = System.Drawing.Color.Black;
            this.btnSensors.Location = new System.Drawing.Point(0, 94);
            this.btnSensors.Name = "btnSensors";
            this.btnSensors.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSensors.Size = new System.Drawing.Size(250, 54);
            this.btnSensors.TabIndex = 0;
            this.btnSensors.Text = "Sensors";
            this.btnSensors.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSensors.UseVisualStyleBackColor = false;
            this.btnSensors.Click += new System.EventHandler(this.btnSensors_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(250, 94);
            this.panelLogo.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LESTOMA_DASHBOARD.Properties.Resources.logoUDEC;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // chartTemp
            // 
            this.chartTemp.Anchor = System.Windows.Forms.AnchorStyles.None;
            chartArea6.Name = "ChartArea1";
            this.chartTemp.ChartAreas.Add(chartArea6);
            legend6.Enabled = false;
            legend6.Name = "Legend1";
            this.chartTemp.Legends.Add(legend6);
            this.chartTemp.Location = new System.Drawing.Point(262, 33);
            this.chartTemp.Name = "chartTemp";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series6.Legend = "Legend1";
            series6.Name = "Temperature";
            this.chartTemp.Series.Add(series6);
            this.chartTemp.Size = new System.Drawing.Size(259, 183);
            this.chartTemp.TabIndex = 5;
            this.chartTemp.Text = "chart1";
            title6.Name = "Title1";
            title6.Visible = false;
            this.chartTemp.Titles.Add(title6);
            // 
            // chartHum
            // 
            this.chartHum.Anchor = System.Windows.Forms.AnchorStyles.None;
            chartArea7.Name = "ChartArea1";
            this.chartHum.ChartAreas.Add(chartArea7);
            legend7.Enabled = false;
            legend7.Name = "Legend1";
            this.chartHum.Legends.Add(legend7);
            this.chartHum.Location = new System.Drawing.Point(541, 33);
            this.chartHum.Name = "chartHum";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series7.Legend = "Legend1";
            series7.Name = "Humidity";
            this.chartHum.Series.Add(series7);
            this.chartHum.Size = new System.Drawing.Size(259, 183);
            this.chartHum.TabIndex = 6;
            this.chartHum.Text = "chartHum";
            title7.Name = "Title1";
            title7.Text = "Humidity";
            title7.Visible = false;
            this.chartHum.Titles.Add(title7);
            // 
            // chartWindDir
            // 
            this.chartWindDir.Anchor = System.Windows.Forms.AnchorStyles.None;
            chartArea8.Name = "ChartArea1";
            this.chartWindDir.ChartAreas.Add(chartArea8);
            legend8.Enabled = false;
            legend8.Name = "Legend1";
            this.chartWindDir.Legends.Add(legend8);
            this.chartWindDir.Location = new System.Drawing.Point(262, 274);
            this.chartWindDir.Name = "chartWindDir";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series8.Legend = "Legend1";
            series8.Name = "WindDirection";
            this.chartWindDir.Series.Add(series8);
            this.chartWindDir.Size = new System.Drawing.Size(259, 183);
            this.chartWindDir.TabIndex = 7;
            this.chartWindDir.Text = "chartWindDir";
            title8.Name = "Title1";
            title8.Text = "Temperature";
            title8.Visible = false;
            this.chartWindDir.Titles.Add(title8);
            // 
            // chartRain
            // 
            this.chartRain.Anchor = System.Windows.Forms.AnchorStyles.None;
            chartArea9.Name = "ChartArea1";
            this.chartRain.ChartAreas.Add(chartArea9);
            legend9.Enabled = false;
            legend9.Name = "Legend1";
            this.chartRain.Legends.Add(legend9);
            this.chartRain.Location = new System.Drawing.Point(541, 274);
            this.chartRain.Name = "chartRain";
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series9.Legend = "Legend1";
            series9.Name = "Rainfall";
            this.chartRain.Series.Add(series9);
            this.chartRain.Size = new System.Drawing.Size(259, 183);
            this.chartRain.TabIndex = 8;
            this.chartRain.Text = "chartRainFl";
            title9.Name = "Title1";
            title9.Text = "Temperature";
            title9.Visible = false;
            this.chartRain.Titles.Add(title9);
            // 
            // chartWindSpd
            // 
            this.chartWindSpd.Anchor = System.Windows.Forms.AnchorStyles.None;
            chartArea10.Name = "ChartArea1";
            this.chartWindSpd.ChartAreas.Add(chartArea10);
            legend10.Enabled = false;
            legend10.Name = "Legend1";
            this.chartWindSpd.Legends.Add(legend10);
            this.chartWindSpd.Location = new System.Drawing.Point(822, 33);
            this.chartWindSpd.Name = "chartWindSpd";
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series10.Legend = "Legend1";
            series10.Name = "WindSpeed";
            this.chartWindSpd.Series.Add(series10);
            this.chartWindSpd.Size = new System.Drawing.Size(259, 183);
            this.chartWindSpd.TabIndex = 9;
            this.chartWindSpd.Text = "chartWinSp";
            title10.Name = "Title1";
            title10.Text = "WindSpeed";
            title10.Visible = false;
            this.chartWindSpd.Titles.Add(title10);
            // 
            // btnRain
            // 
            this.btnRain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRain.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRain.FlatAppearance.BorderSize = 0;
            this.btnRain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRain.ForeColor = System.Drawing.Color.LightGray;
            this.btnRain.Location = new System.Drawing.Point(0, 308);
            this.btnRain.Name = "btnRain";
            this.btnRain.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnRain.Size = new System.Drawing.Size(250, 40);
            this.btnRain.TabIndex = 10;
            this.btnRain.Text = "Rainfall: ... RF";
            this.btnRain.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRain.UseVisualStyleBackColor = false;
            // 
            // btnWindDirection
            // 
            this.btnWindDirection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnWindDirection.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnWindDirection.FlatAppearance.BorderSize = 0;
            this.btnWindDirection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWindDirection.ForeColor = System.Drawing.Color.LightGray;
            this.btnWindDirection.Location = new System.Drawing.Point(0, 268);
            this.btnWindDirection.Name = "btnWindDirection";
            this.btnWindDirection.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnWindDirection.Size = new System.Drawing.Size(250, 40);
            this.btnWindDirection.TabIndex = 9;
            this.btnWindDirection.Text = "WindDirection: ...°";
            this.btnWindDirection.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWindDirection.UseVisualStyleBackColor = false;
            // 
            // btnWindSpd
            // 
            this.btnWindSpd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnWindSpd.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnWindSpd.FlatAppearance.BorderSize = 0;
            this.btnWindSpd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWindSpd.ForeColor = System.Drawing.Color.LightGray;
            this.btnWindSpd.Location = new System.Drawing.Point(0, 228);
            this.btnWindSpd.Name = "btnWindSpd";
            this.btnWindSpd.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnWindSpd.Size = new System.Drawing.Size(250, 40);
            this.btnWindSpd.TabIndex = 8;
            this.btnWindSpd.Text = "WindSpeed: ... km/h";
            this.btnWindSpd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWindSpd.UseVisualStyleBackColor = false;
            // 
            // btnHumidity
            // 
            this.btnHumidity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnHumidity.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHumidity.FlatAppearance.BorderSize = 0;
            this.btnHumidity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHumidity.ForeColor = System.Drawing.Color.LightGray;
            this.btnHumidity.Location = new System.Drawing.Point(0, 188);
            this.btnHumidity.Name = "btnHumidity";
            this.btnHumidity.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnHumidity.Size = new System.Drawing.Size(250, 40);
            this.btnHumidity.TabIndex = 7;
            this.btnHumidity.Text = "Humidity: ... %HR";
            this.btnHumidity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHumidity.UseVisualStyleBackColor = false;
            // 
            // btnTemp
            // 
            this.btnTemp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnTemp.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTemp.FlatAppearance.BorderSize = 0;
            this.btnTemp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTemp.ForeColor = System.Drawing.Color.LightGray;
            this.btnTemp.Location = new System.Drawing.Point(0, 148);
            this.btnTemp.Name = "btnTemp";
            this.btnTemp.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnTemp.Size = new System.Drawing.Size(250, 40);
            this.btnTemp.TabIndex = 6;
            this.btnTemp.Text = "Temperature: ... °C";
            this.btnTemp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTemp.UseVisualStyleBackColor = false;
            // 
            // lblWindSpeed
            // 
            this.lblWindSpeed.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblWindSpeed.AutoSize = true;
            this.lblWindSpeed.Location = new System.Drawing.Point(819, 12);
            this.lblWindSpeed.Name = "lblWindSpeed";
            this.lblWindSpeed.Size = new System.Drawing.Size(127, 16);
            this.lblWindSpeed.TabIndex = 10;
            this.lblWindSpeed.Text = "WindSpeed: ... km/h";
            // 
            // lblHumidity
            // 
            this.lblHumidity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHumidity.AutoSize = true;
            this.lblHumidity.Location = new System.Drawing.Point(538, 12);
            this.lblHumidity.Name = "lblHumidity";
            this.lblHumidity.Size = new System.Drawing.Size(110, 16);
            this.lblHumidity.TabIndex = 11;
            this.lblHumidity.Text = "Humidity: ... %HR";
            // 
            // lblTemp
            // 
            this.lblTemp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTemp.AutoSize = true;
            this.lblTemp.Location = new System.Drawing.Point(259, 12);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(117, 16);
            this.lblTemp.TabIndex = 12;
            this.lblTemp.Text = "Temperature: ... °C";
            // 
            // lblRainFall
            // 
            this.lblRainFall.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRainFall.AutoSize = true;
            this.lblRainFall.Location = new System.Drawing.Point(538, 248);
            this.lblRainFall.Name = "lblRainFall";
            this.lblRainFall.Size = new System.Drawing.Size(89, 16);
            this.lblRainFall.TabIndex = 13;
            this.lblRainFall.Text = "Rainfall: ... RF";
            // 
            // lblWindDir
            // 
            this.lblWindDir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblWindDir.AutoSize = true;
            this.lblWindDir.Location = new System.Drawing.Point(259, 248);
            this.lblWindDir.Name = "lblWindDir";
            this.lblWindDir.Size = new System.Drawing.Size(118, 16);
            this.lblWindDir.TabIndex = 14;
            this.lblWindDir.Text = "WindDireccion: ... °";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 492);
            this.Controls.Add(this.lblWindDir);
            this.Controls.Add(this.lblRainFall);
            this.Controls.Add(this.lblTemp);
            this.Controls.Add(this.lblHumidity);
            this.Controls.Add(this.lblWindSpeed);
            this.Controls.Add(this.chartWindSpd);
            this.Controls.Add(this.chartRain);
            this.Controls.Add(this.chartWindDir);
            this.Controls.Add(this.chartHum);
            this.Controls.Add(this.chartTemp);
            this.Controls.Add(this.panelSideMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelSideMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTemp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartHum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartWindDir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartWindSpd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Button btnSensors;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_BaudRate;
        private System.Windows.Forms.ComboBox comboBox_PortList;
        private System.Windows.Forms.Label label1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTemp;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartHum;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartWindDir;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRain;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartWindSpd;
        private System.Windows.Forms.Button btnRain;
        private System.Windows.Forms.Button btnWindDirection;
        private System.Windows.Forms.Button btnWindSpd;
        private System.Windows.Forms.Button btnHumidity;
        private System.Windows.Forms.Button btnTemp;
        private System.Windows.Forms.Label lblWindSpeed;
        private System.Windows.Forms.Label lblHumidity;
        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.Label lblRainFall;
        private System.Windows.Forms.Label lblWindDir;
    }
}

