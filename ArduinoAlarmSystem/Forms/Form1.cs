using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArduinoAlarmSystem.Forms
{
    public partial class Form1 : Form
    {
        static private Arduino ardu;// = new Arduino("COM7", 9600);
        public string inData = "";
        public int timerValue;

        public Form1()
        {
            InitializeComponent();
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string activeCom = comboBox1.SelectedItem.ToString();
            ardu = new Arduino(9600);
            ardu.ReadSerial();
           
            textBox1.Clear();
            timer1.Start();
            //MessageBox.Show(ardu.serialData.ToString());

            
        }

        private void CheckData()
        {
            //string activeCom = comboBox1.SelectedItem.ToString();
            //Arduino ardu = new Arduino("COM7", 9600);
            string[] serialString;
            inData = "";
            inData = ardu.serialData;

            serialString = inData.Split('#');
            
            foreach (string data in serialString)

            {
                //MessageBox.Show("" + serialString[0] + " & " + serialString[1]);
                
                string TData = serialString[0].Substring(1,4);
                TData = TData.Replace('.',',');
                //double.TryParse(serialData, out temperature);
                ardu.temperature = Convert.ToDouble(TData);
              
                string MData = serialString[1].Substring(1,1 );
                //bool.TryParse(MData, out ardu.motion);
                
                byte.TryParse(MData,out byte boolData);
                ardu.motion = Convert.ToBoolean(boolData);

            }
        }
        private void WriteSql()
        {
            //string activeCom = comboBox1.SelectedItem.ToString();

            //Arduino ardu = new Arduino("com7", 9600);
            SqlCon readIn = new SqlCon();
            double readTemp;
            readTemp = ardu.temperature;
            //run sql class, calling procedure for writing data to sql
            readIn.TempLogging(readTemp);
            //check for motion alarm trigger value 
            if (ardu.motion == true)
            {
                //run sql class, calling procedure for writing data to sql
                readIn.PIRAlarm();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //string activeCom = comboBox1.SelectedItem.ToString();
            //Arduino ardu = new Arduino("COM7", 9600);
            //if data is available from arduino
            if (ardu.dataReady)
            {
                textBox2.BackColor = Color.Green;
                //check  data and separate into 2 individual values
                CheckData();
                //Write Sql data, motion and temperatur to sql
                WriteSql();
                

            }

            ardu.dataReady = false;
            //print raw data and sorted data in textbox
            textBox1.Text += inData + "\r\nTemp: " + ardu.temperature + " & Alarm: " + ardu.motion +"..\r\n";// + ardu.dataCount;
            textBox2.BackColor = Color.Red;
              
        }


        private void button2_Click(object sender, EventArgs e)
        {
            //stop artuino serial and timer
            Arduino arduStop  = new Arduino(false);
            timer1.Stop();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Arduino ardu = new Arduino();
            foreach (string port in ardu.ports)
            {
                comboBox1.Items.Add(port);
                


            }
            if (comboBox1.Items.Count.Equals(0) )//|| port == null)
            {
                comboBox1.Items.Add("Port unavailable");
            }
            comboBox1.SelectedIndex = 0;
        }
    }
}
