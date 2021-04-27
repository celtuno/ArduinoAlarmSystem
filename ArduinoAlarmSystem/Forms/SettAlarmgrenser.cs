using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArduinoAlarmSystem
{
    public partial class AlarmLimit : Form
    {
        public AlarmLimit()
        {
            InitializeComponent();
            SqlCon sqlCon = new SqlCon();
        }

        private void btnBackAlarmgrenser_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInsertNewLimits_Click(object sender, EventArgs e)
        {
            SqlCon sqlCon = new SqlCon();
            FileHandling FH = new FileHandling();

            int batperc, readInterval, delayInteval, tempError;
            double limitHigh, limitLow;
            bool pir = false;
            string comPort;

            batperc = Convert.ToInt32(txtBatPerc.Text);
            limitHigh = Convert.ToDouble(txtTempHigh.Text);
            limitLow = Convert.ToDouble(txtTempLow.Text);
            readInterval = Convert.ToInt32(txtReadInterval.Text);
            delayInteval = Convert.ToInt32(txtDelayIntervalAfterAlarm.Text);
            tempError = Convert.ToInt32(txtTempErrorLimit.Text);

            if (cboMotion.Text == "ON")
            {
                pir = true;
            }
            else { pir = false; }

            sqlCon.DefineLimits(limitLow, limitHigh, batperc, pir);
            
            if (cboPorts.SelectedItem != null)
            {

                comPort = cboPorts.SelectedItem.ToString();

                FH.FileWriter(tempError, readInterval, delayInteval, comPort);
            }
            else
            {
                FH.FileWriter(tempError, readInterval, delayInteval);

            }
            
            
        }

        private void AlarmLimit_Load(object sender, EventArgs e)
        {
            Arduino ardu = new Arduino();
            foreach (string port in ardu.ports)
            {
                cboPorts.Items.Add(port);
            }
        }
    }
}
