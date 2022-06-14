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
using System.Threading;

namespace LESTOMA_DASHBOARD
{
    public partial class Form1 : Form
    {
        double temperature = 0,humidity = 0,windspeed = 0,winddirection = 0,rainfall = 0;
        bool updateData = false;
        string dataIn;
        int time = 10000;
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
        // listrade puertos
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

        private void showthething_Click(object sender, EventArgs e)
        {
        
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ShowSeparated_Click(object sender, EventArgs e)
        {

        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            
            dataIn = serialPort1.ReadTo("\n");
                 

            this.Invoke(new EventHandler(ShowData));
            // Data_Parsing(dataIn);
             this.BeginInvoke(new EventHandler(Show_Data));
        }

        private void ShowData(object sender, EventArgs e)
        {
            
            var string_arr = dataIn.Split('|');
           
            var string_byte = string_arr[1].Split('-');
            Array.Reverse(string_byte);

            for(int i = 0; i < 4; i++)
            {
                string cosa=string_byte[i].ToString();
                lbl2.Text = cosa;
            }
            
            string sens1 = string_byte[0].ToString() + string_byte[1].ToString() + string_byte[2].ToString() + string_byte[3].ToString() ; 
            uint nu = uint.Parse(sens1, System.Globalization.NumberStyles.AllowHexSpecifier);
            lbl1.Text = sens1.ToString();

            
            byte[] ba = BitConverter.GetBytes(nu);
            float tmp = BitConverter.ToSingle(ba,0);
            decimal temp = new decimal (tmp);
            temperature = (double)temp;
            /*

            var string_byte2 = string_arr[2].Split('-');
            Array.Reverse(string_byte2);
            string sens2 = string_byte2[0].ToString() + string_byte2[1].ToString() + string_byte2[2].ToString() + string_byte2[3].ToString() + string_byte2[4].ToString();
            lbl1.Text = sens2.ToString();
            /*
            uint nu2 = uint.Parse(sens2, System.Globalization.NumberStyles.AllowHexSpecifier);
            byte[] ba2 = BitConverter.GetBytes(nu2);
            float hum = BitConverter.ToSingle(ba2, 0);
            decimal humi = new decimal(hum);
            humidity = (double)humi;

            string[] string_byte3 = string_arr[3].Split('-');
            Array.Reverse(string_byte3);
            string sens3 = string_byte3[0].ToString() + string_byte3[1].ToString() + string_byte3[2].ToString() + string_byte3[3].ToString() + string_byte3[4].ToString();
            lbl1.Text = sens3.ToString();

            /*
            uint nu3 = uint.Parse(sens3, System.Globalization.NumberStyles.AllowHexSpecifier);
            byte[] ba3 = BitConverter.GetBytes(nu3);
            float winds = BitConverter.ToSingle(ba3, 0);
            decimal windsp = new decimal(winds);
            windspeed = (double)windsp;
            

            var string_byte4 = string_arr[4].Split('-');
            Array.Reverse(string_byte4);
            string sens4 = string_byte4[0].ToString() + string_byte4[1].ToString() + string_byte4[2].ToString() + string_byte4[3].ToString() + string_byte4[4].ToString();
            lbl1.Text = sens4.ToString();
            /*
            uint nu4 = uint.Parse(sens4, System.Globalization.NumberStyles.AllowHexSpecifier);
            byte[] ba4 = BitConverter.GetBytes(nu4);
            float windd = BitConverter.ToSingle(ba4, 0);
            decimal winddir = new decimal(windd);
            winddirection = (double)winddir;
            
            var string_byte5 = string_arr[5].Split('-');
            Array.Reverse(string_byte5);
            string sens5 = string_byte5[0].ToString() + string_byte5[1].ToString() + string_byte5[2].ToString() + string_byte5[3].ToString() + string_byte5[4].ToString();
            lbl1.Text = sens5.ToString();

            /*uint nu5 = uint.Parse(sens5, System.Globalization.NumberStyles.AllowHexSpecifier);
            byte[] ba5 = BitConverter.GetBytes(nu5);
            float rnf = BitConverter.ToSingle(ba5, 0);
            decimal rainfa = new decimal(rnf);
            rainfall = (double)rainfa; */

            updateData = true;
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
                    //temperature = Convert.ToDouble(str_temperature);
                    string str_Humidity = data.Substring(indexOfA + 1, (indexOfB - indexOfA) - 1);
                    //humidity = Convert.ToDouble(str_Humidity);
                    string str_WindSpeed = data.Substring(indexOfB + 1, (indexOfC - indexOfB) - 1);
                    //windspeed = Convert.ToDouble(str_WindSpeed);
                    string str_WindDirection = data.Substring(indexOfC + 1, (indexOfD - indexOfC) - 1);
                    //winddirection = Convert.ToDouble(str_WindDirection);
                    string str_Rainfall = data.Substring(indexOfD + 1, (indexOfE - indexOfD) - 1);
                    //rainfall = Convert.ToDouble(str_Rainfall);

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
