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

namespace ArduinoAlarmSystem.Forms
{
    public partial class ChangeUserSettings : Form
    {
        
        string Alarm = ConfigurationManager.ConnectionStrings["Alarm"].ConnectionString;// Connectionstring to the database
        string comboboxUser = @"select UserId
                                from [USER]";// String that selects all userId's in a query.


        public void ImportToComboBox(ComboBox comboBox, string sqlQuery)// Method for importing text from the database to combobox 
        {
            SqlConnection conAlarmDatabase = new SqlConnection(Alarm);
            SqlCommand sqlCommand = new SqlCommand(sqlQuery, conAlarmDatabase);
            sqlCommand.CommandType = CommandType.Text;
            conAlarmDatabase.Open();
            SqlDataReader dataReader = sqlCommand.ExecuteReader();
            while (dataReader.Read() == true)
            {
                sqlQuery = dataReader[0].ToString();
                comboBox.Items.Add(sqlQuery);
            }
        }

        public ChangeUserSettings()
        {
            InitializeComponent();
            ImportToComboBox(cboUserRoll, comboboxUser);// Uses the method for importing to combobox with the selected combobox and string query
        }

        private void btnLoadCurrentValues_Click(object sender, EventArgs e)
        {
            int userid;// sets the userid as int
            userid = Convert.ToInt32(cboUserRoll.Text); // setting the number in the textbox as userid, and converts it to int.
            SqlCon sqlCon = new SqlCon();
            string[] userArray = sqlCon.GetUserData(userid);// creating an array that gets the userinformation from the selected userId.
            txtFirstName.Text = userArray[0];// Setting the selected textbox text as the selected information from the array.
            txtLastName.Text = userArray[1];
            txtEmail.Text = userArray[2];
            txtPhoneNumber.Text = userArray[3];
            cboLowBat.Text = userArray[4];
            cboBatCharging.Text = userArray[5];
            cboLowTemp.Text = userArray[6];
            cboHighTemp.Text = userArray[7];
            cboPir.Text = userArray[8];
            cboEmail.Text = userArray[9];
            cboAdmin.Text = userArray[10];
            txtPassword.Text = userArray[11];
        }

        private void btnComittChanges_Click(object sender, EventArgs e)
        {
            string firstName, lastName, eMail, password;//Stored string value
            int phoneNumber, userId;//Stored int value
            bool isAdmin, batteryAlert, batteryCharge, tempHigh, tempLow, pirAlert, eMailAlert;// Stored boolean value
            firstName = txtFirstName.Text;// Reading from textbox and storing it to the stored value.
            lastName = txtLastName.Text;
            eMail = txtEmail.Text;
            password = txtPassword.Text;
            phoneNumber =Convert.ToInt32(txtPhoneNumber.Text);
            userId = Convert.ToInt32(cboUserRoll.Text);
            if (cboAdmin.Text=="YES")
            {
                isAdmin = true;
            }
            else if (cboAdmin.Text == "True")
            {
                isAdmin = true;
            }
            else { isAdmin = false; }
            if (cboLowBat.Text == "YES")
            {
                batteryAlert = true;
            }
            else if (cboLowBat.Text == "True")
            {
                batteryAlert = true;
            }
            else { batteryAlert = false; }
            if (cboBatCharging.Text == "YES")
            {
                batteryCharge = true;
            }
            else if (cboBatCharging.Text == "True")
            {
                batteryCharge = true;
            }
            else { batteryCharge = false; }
            if (cboHighTemp.Text == "YES")
            {
                tempHigh = true;
            }
            else if (cboHighTemp.Text == "True")
            {
                tempHigh = true;
            }
            else { tempHigh = false; }
            if (cboLowTemp.Text == "YES")
            {
                tempLow = true;
            }
            else if (cboLowTemp.Text == "True")
            {
                tempLow = true;
            }
            else { tempLow = false; }
            if (cboPir.Text == "YES")
            {
                pirAlert = true;
            }
            else if (cboPir.Text == "True")
            {
                pirAlert = true;
            }
            else { pirAlert = false; }
            if (cboEmail.Text == "YES")
            {
                eMailAlert = true;
            }
            else if (cboEmail.Text == "True")
            {
                eMailAlert = true;
            }
            else { eMailAlert = false; }

            SqlCon sqlCon = new SqlCon();
            sqlCon.ChangeUserData(firstName, lastName, eMail, phoneNumber, batteryAlert, batteryCharge, tempLow,
                  tempHigh, pirAlert, eMailAlert, isAdmin, password, userId);// Calls upon the method in sqlCon that changes the data in the database to the new changes.
        }
    }
}
