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
    public partial class CurrentValues : Form

    {

        public string test;
        GlobalData dta = new GlobalData();
        GlobalTimer tmr = new GlobalTimer();
        
        public CurrentValues()
        {
            InitializeComponent();
            
        }

        private void CurrentValues_Load(object sender, EventArgs e)
        {
             
            tmrBattery.Start(); //starts timer

            

           
        }
       
        private void tmrBattery_Tick(object sender, EventArgs e)
        {

            if (tmr.ErrorCheck)
            {
                txtCurrentMSensor.Text = "Error";
                txtCurrentTemp.Text = "Error";
            }
            else
            {
                txtCurrentTemp.Text = dta.getTemp();
                txtCurrentMSensor.Text = dta.getMotion();
            }
            
            PowerStatus p = SystemInformation.PowerStatus;
            int a = (int)(p.BatteryLifePercent * 100); // finds batterypercent and turns 
            txtCurrentBattery.Text = a.ToString() + " %";//Writes Battery % to textbox
            //PowerTest(a);

            Boolean power = (SystemInformation.PowerStatus.PowerLineStatus == PowerLineStatus.Offline); //Checks if battery is connected to power source

            if (power == true)
            {
                txtBatCharging.Text = "NO"; // Battery not charging 
            }
            else
            {
                txtBatCharging.Text = "YES"; // Battery charging
            }
            




        }

        private void CurrentValues_FormClosed(object sender, FormClosedEventArgs e)
        {
            tmrBattery.Stop();  
        }
    }
}
