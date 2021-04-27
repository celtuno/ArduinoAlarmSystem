using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArduinoAlarmSystem
{
    public partial class SubscriberPage : Form
    {
        public SubscriberPage()
        {
            InitializeComponent();
        }

        private void btnBackSubscriberPage_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
                string password, firstName, lastName, eMail;
                int phone;
                bool bat, batVolt, tempLow, tempHigh, pir, isAdmin, eMailAlert;
                password = txtPassword.Text;
                firstName = txtFName.Text;
                lastName = txtLName.Text;
                eMail = txtEMail.Text;
                phone = Convert.ToInt32(txtPhoneNum.Text);

                if (cboIsAdmin.Text == "Yes")
                {
                    isAdmin = true;
                }
                else
                {
                    isAdmin = false;
                }
                if (cboLowBat.Text == "Yes")
                {
                    bat = true;
                }
                else
                {
                    bat = false;
                }
                if (cboBatCharging.Text == "Yes")
                {
                    batVolt = true;
                }
                else
                {
                    batVolt = false;
                }
                if (cboMotionAlert.Text == "Yes")
                {
                    pir = true;
                }
                else
                {
                    pir = false;
                }
                if (cboTempLow.Text == "Yes")
                {
                    tempLow = true;
                }
                else
                {
                    tempLow = false;
                }
                if (cboTempHigh.Text == "Yes")
                {
                    tempHigh = true;
                }
                else
                {
                    tempHigh = false;
                }
                if (cboEmailAlert.Text == "Yes")
                {
                    eMailAlert = true;
                }
                else
                {
                    eMailAlert = false;
                }
                SqlCon sqlCon = new SqlCon();
                sqlCon.CreateNewUser(firstName, lastName, eMail, phone, bat, batVolt, tempLow, pir, tempHigh, isAdmin, eMailAlert, password);
            // Calls on the CreateNewUser method from sqlCon to enter the new user information to the database.
        }
    }
    
}
