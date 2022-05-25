using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace LESTOMA_DASHBOARD
{
    public partial class Form1 : Form
    {
        Double temperature = 0,humidity = 0,windspeed = 0,winddirection = 0,rainfall = 0;
        bool updateData = false;
        public Form1()
        {
            InitializeComponent();
            customizeDesign();
        }
        private void customizeDesign()
        {
           
        }
        private void hideSubMenu()
        {
            
        }

        private void btnSensors_Click(object sender, EventArgs e)
        {

        }

        private void btnTemp_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

 

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnOpen.Enabled = true;
            btnClose.Enabled = false;

            chartTemp.Series["Temperature"].Points.AddXY(1, 1);
            chartHum.Series["Humidity"].Points.AddXY(1, 1);
            chartWindSpd.Series["WindSpeed"].Points.AddXY(1, 1);
            chartWindDir.Series["WindDirection"].Points.AddXY(1, 1);
            chartRain.Series["Rainfall"].Points.AddXY(1, 1);
        }

        private void comboBox_PortList_DropDown(object sender, EventArgs e)
        {
            string[] portList = SerialPort.GetPortNames();
            comboBox_PortList.Items.Clear();
            comboBox_PortList.Items.AddRange(portList);
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = comboBox_PortList.Text;
                serialPort1.BaudRate = Convert.ToInt32(comboBox_BaudRate.Text);
                serialPort1.Open();


                btnOpen.Enabled = false;
                btnClose.Enabled = true;

                chartTemp.Series["Temperature"].Points.Clear();
                chartHum.Series["Humidity"].Points.Clear();
                chartWindSpd.Series["WindSpeed"].Points.Clear();
                chartWindDir.Series["WindDirection"].Points.Clear();
                chartRain.Series["Rainfall"].Points.Clear();

                MessageBox.Show("Success Connected to Station");

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Close();


                btnOpen.Enabled = true;
                btnClose.Enabled = false;

                MessageBox.Show("Disconnected Connected to Station");

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string dataIn = serialPort1.ReadTo("\n");
            Data_Parsing(dataIn);
            this.BeginInvoke(new EventHandler(Show_Data));
        }

        private void Show_Data(object sender, EventArgs e)
        {
            if(updateData == true)
            {
                btnTemp.Text = String.Format("Temperature: {0} °C",temperature.ToString());
                lblTemp.Text = String.Format("Temperature: {0} °C", temperature.ToString());
                chartTemp.Series["Temperature"].Points.Add(temperature);

                btnHumidity.Text = String.Format("Humidity: {0} %HR", humidity.ToString());
                lblHumidity.Text = String.Format("Humidity: {0} %HR", humidity.ToString());
                chartHum.Series["Humidity"].Points.Add(humidity);

                btnWindSpd.Text = String.Format("WindSpeed: {0} km/h", windspeed.ToString());
                lblWindSpeed.Text = String.Format("WindSpeed: {0} km/h", windspeed.ToString());
                chartWindSpd.Series["WindSpeed"].Points.Add(windspeed);

                btnWindDirection.Text = String.Format("WindDirection: {0} °", winddirection.ToString());
                lblWindDir.Text = String.Format("WindDirection: {0} °", winddirection.ToString());
                chartWindDir.Series["WindDirection"].Points.Add(winddirection);

                btnRain.Text = String.Format("Rainfall: {0} RF", rainfall.ToString());
                lblRainFall.Text = String.Format("Rainfall: {0} RF", rainfall.ToString());
                chartRain.Series["Rainfall"].Points.Add(rainfall); 

            }

            
        }

        private void Data_Parsing(string data)
        {
            sbyte indexOf_StartDataCharacter = (sbyte)data.IndexOf("@");
            sbyte indexOfA = (sbyte)data.IndexOf("A");
            sbyte indexOfB = (sbyte)data.IndexOf("B");
            sbyte indexOfC = (sbyte)data.IndexOf("C");
            sbyte indexOfD = (sbyte)data.IndexOf("D");
            sbyte indexOfE = (sbyte)data.IndexOf("E");

            if (indexOfA != -1 && indexOfB != -1 && indexOfC != -1 && indexOfD != -1 && indexOfE != -1 && indexOf_StartDataCharacter != -1)
            {
                try
                {
                    string str_temperature = data.Substring(indexOf_StartDataCharacter + 1, (indexOfA - indexOf_StartDataCharacter) - 1);
                    temperature = Convert.ToDouble(str_temperature);
                    string str_Humidity = data.Substring(indexOfA + 1, (indexOfB - indexOfA) - 1);
                    humidity = Convert.ToDouble(str_Humidity);
                    string str_WindSpeed = data.Substring(indexOfB + 1, (indexOfC - indexOfB) - 1);
                    windspeed = Convert.ToDouble(str_WindSpeed);
                    string str_WindDirection = data.Substring(indexOfC + 1, (indexOfD - indexOfC) - 1);
                    winddirection = Convert.ToDouble(str_WindDirection);
                    string str_Rainfall = data.Substring(indexOfD + 1, (indexOfE - indexOfD) - 1);
                    rainfall = Convert.ToDouble(str_Rainfall);

                    updateData = true;
                }
                catch (Exception)
                {

                }

                }
            
            else
            {
                updateData = false;
            }
        }

    }
}
