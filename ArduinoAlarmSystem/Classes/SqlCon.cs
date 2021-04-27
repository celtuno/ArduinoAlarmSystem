using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArduinoAlarmSystem
{
    struct alarmLimits
    {
       public bool PIR;
       public double tempHigh, tempLow;
       public int battPercent;
        public bool alarmLimitsSet ;
    }
        
    class SqlCon
    {
        string Alarm = ConfigurationManager.ConnectionStrings["Alarm"].ConnectionString;// Connectionstring to the database.

        public alarmLimits GetAlarmLimits()
        {
            alarmLimits rv = new alarmLimits();

            try
            {
                SqlConnection conAlarmDatabase = new SqlConnection(Alarm);
                SqlCommand sqlCommand = new SqlCommand("GetAlarmLimits", conAlarmDatabase);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                conAlarmDatabase.Open();
                sqlCommand.ExecuteNonQuery();
                SqlDataReader dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read() == true)
                {
                    rv.tempHigh = Convert.ToInt32(dataReader[0].ToString());
                    rv.tempLow = Convert.ToInt32(dataReader[1].ToString());
                    rv.battPercent = Convert.ToInt32(dataReader[2].ToString());
                    rv.PIR = Convert.ToBoolean(dataReader[3].ToString());
                }
                conAlarmDatabase.Close();
                rv.alarmLimitsSet = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("SqlError:\r\n" + ex.Message, "Sql error", MessageBoxButtons.OK,MessageBoxIcon.Warning );
                rv.alarmLimitsSet = false;
                return new alarmLimits();
            }

            return rv;
        }

        public void DefineLimits(double low, double high, int batPercentage, bool pir) // Method for adding new limits to alarmsettings
        {
            try
            {
                SqlConnection conAlarmDatabase = new SqlConnection(Alarm); //Connection to the database
                SqlCommand sqlCommand = new SqlCommand("InsertNewLimits", conAlarmDatabase);//SqlCommand with parameters with the name of the stored procedure and connection to the database
                sqlCommand.CommandType = CommandType.StoredProcedure;//Selecting command type
                conAlarmDatabase.Open();//Opening connection 
                sqlCommand.Parameters.Add(new SqlParameter("@highLimit", high));//Selecting value to be inserted into the parameter
                sqlCommand.Parameters.Add(new SqlParameter("@lowLimit", low));
                sqlCommand.Parameters.Add(new SqlParameter("@batpercentage", batPercentage));
                sqlCommand.Parameters.Add(new SqlParameter("@pirOn", pir));
                sqlCommand.ExecuteNonQuery();//Execute
                conAlarmDatabase.Close();//Closing connection
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); // catches any faults in insertions of numbers to the database.
            }
        }
        public void PIRAlarm() // Method for inserting values when the PIR goes off
        {
            try
            {
                SqlConnection conAlarmDatabase = new SqlConnection(Alarm);
                SqlCommand sqlCommand = new SqlCommand("MotionAlarm", conAlarmDatabase);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                conAlarmDatabase.Open();
                sqlCommand.ExecuteNonQuery();
                conAlarmDatabase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void BatAlert(int batPerc) // method for inserting values if battery alarm goes off
        {
            try
            {
                SqlConnection conAlarmDatabase = new SqlConnection(Alarm);
                SqlCommand sqlCommand = new SqlCommand("BatteryAlert", conAlarmDatabase);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                conAlarmDatabase.Open();
                sqlCommand.Parameters.Add(new SqlParameter("@batAlert", batPerc));
                sqlCommand.ExecuteNonQuery();
                conAlarmDatabase.Close();
            }
            catch (Exception ex)
            {
               MessageBox.Show(ex.Message);
            }
        }
        public void BatteryVoltageAlert(int batVolt)
        {
            try
            {
                SqlConnection conAlarmDatabase = new SqlConnection(Alarm);
                SqlCommand sqlCommand = new SqlCommand("BatVoltAlert", conAlarmDatabase);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                conAlarmDatabase.Open();
                sqlCommand.Parameters.Add(new SqlParameter("@BatvoltAlert", batVolt));
                sqlCommand.ExecuteNonQuery();
                conAlarmDatabase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void TempAlarm(double tempValue)
        {
            try
            {
                SqlConnection conAlarmDatabase = new SqlConnection(Alarm);
                SqlCommand sqlCommand = new SqlCommand("TempValueInsertToAlarms", conAlarmDatabase);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                conAlarmDatabase.Open();
                sqlCommand.Parameters.Add(new SqlParameter("@tempValue", tempValue));
                sqlCommand.ExecuteNonQuery();
                conAlarmDatabase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void TempLogging(double tempValueLog)
        {
            try
            {
                SqlConnection conAlarmDatabase = new SqlConnection(Alarm);
                SqlCommand sqlCommand = new SqlCommand("TempAlarmInsert", conAlarmDatabase);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                conAlarmDatabase.Open();
                sqlCommand.Parameters.Add(new SqlParameter("@tempInn", tempValueLog));
                sqlCommand.ExecuteNonQuery();
                conAlarmDatabase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void CreateNewUser(string firstName, string lastName, string eMail, int phone, bool bat, bool batVolt, bool tempLow,
                                    bool pir, bool tempHigh, bool isAdmin, bool eMailAlert, string password)//Method for creating a new user in the system
        {

            try
            {
                SqlConnection conAlarmDatabase = new SqlConnection(Alarm);
                SqlCommand sqlCommand = new SqlCommand("CreateNewUser", conAlarmDatabase);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                conAlarmDatabase.Open();
                sqlCommand.Parameters.Add(new SqlParameter("@FirstName", firstName));
                sqlCommand.Parameters.Add(new SqlParameter("@LastName", lastName));
                sqlCommand.Parameters.Add(new SqlParameter("@EMail", eMail));
                sqlCommand.Parameters.Add(new SqlParameter("@PhoneNumber", phone));
                sqlCommand.Parameters.Add(new SqlParameter("@Battery", bat));
                sqlCommand.Parameters.Add(new SqlParameter("@BatteryVoltage", batVolt));
                sqlCommand.Parameters.Add(new SqlParameter("@TempLow", tempLow));
                sqlCommand.Parameters.Add(new SqlParameter("@PIR", pir));
                sqlCommand.Parameters.Add(new SqlParameter("@TempHigh", tempHigh));
                sqlCommand.Parameters.Add(new SqlParameter("@IsAdmin", isAdmin));
                sqlCommand.Parameters.Add(new SqlParameter("@Password", password));
                sqlCommand.Parameters.Add(new SqlParameter("@EMailAlert", eMailAlert));
                sqlCommand.ExecuteNonQuery();
                conAlarmDatabase.Close();
                MessageBox.Show("User succesfully added!");

                // uses a stored procedure to add a new user with the chosen information and what information they want. It also generates a new userId that goes one up from 
                // the highest userId that already exist.
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public void TempError(double tempValueError)
        {
            try
            {
                SqlConnection conAlarmDatabase = new SqlConnection(Alarm);
                SqlCommand sqlCommand = new SqlCommand("TempErrorAlarm", conAlarmDatabase);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                conAlarmDatabase.Open();
                sqlCommand.Parameters.Add(new SqlParameter("@tempValueError", tempValueError));
                sqlCommand.ExecuteNonQuery();
                conAlarmDatabase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public string[] GetUserData(int UserId)// Method for getting all userdata from the selected user.
        {
            string[] UserData = new string[12];// array for information of the selected user.
            try
            {
                SqlConnection conAlarmDatabase = new SqlConnection(Alarm);//Connection to database
                SqlCommand sqlCommand = new SqlCommand("GetUserData", conAlarmDatabase);//sqlCommand with parameters for name of the stored precedure and connection.
                sqlCommand.CommandType = CommandType.StoredProcedure;// Selecting command type.
                conAlarmDatabase.Open();//Opening the connection
                sqlCommand.Parameters.Add(new SqlParameter("@UserId", UserId));// Using the parameter from the stored procedure and giving it a number.
                sqlCommand.ExecuteNonQuery();// Executing
                SqlDataReader dataReader = sqlCommand.ExecuteReader();// Executing reader for the data
                while (dataReader.Read() == true)//While loop
                {
                    UserData[0] = dataReader[0].ToString();// Reads the data from the database into the array UserData
                    UserData[1] = dataReader[1].ToString();
                    UserData[2] = dataReader[2].ToString();
                    UserData[3] = dataReader[3].ToString();
                    UserData[4] = dataReader[4].ToString();
                    UserData[5] = dataReader[5].ToString();
                    UserData[6] = dataReader[6].ToString();
                    UserData[7] = dataReader[7].ToString();
                    UserData[8] = dataReader[8].ToString();
                    UserData[9] = dataReader[9].ToString();
                    UserData[10] = dataReader[10].ToString();
                    UserData[11] = dataReader[11].ToString();
                }
                conAlarmDatabase.Close();//Closing connection to the database.
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return UserData;// Return the array UserData.
        }
        public void ChangeUserData(string fName, string lName, string eMail, int phoneNum, bool batAlert, bool batCharge, bool tempLow,
            bool tempHigh, bool pir, bool emailAlert, bool isAdmin, string password, int userId)// Method for changing the userdata in the database.
        {
            try
            {
                SqlConnection conAlarmDatabase = new SqlConnection(Alarm);
                SqlCommand sqlCommand = new SqlCommand("[ChangeUserSettings]", conAlarmDatabase);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                conAlarmDatabase.Open();
                sqlCommand.Parameters.Add(new SqlParameter("@Fname", fName));
                sqlCommand.Parameters.Add(new SqlParameter("@Lname", lName));
                sqlCommand.Parameters.Add(new SqlParameter("@Email", eMail));
                sqlCommand.Parameters.Add(new SqlParameter("@PhoneNum", phoneNum));
                sqlCommand.Parameters.Add(new SqlParameter("@BatAlert", batAlert));
                sqlCommand.Parameters.Add(new SqlParameter("@BatCharg", batCharge));
                sqlCommand.Parameters.Add(new SqlParameter("@tempLowAlert", tempLow));
                sqlCommand.Parameters.Add(new SqlParameter("@tempHighAlert", tempHigh));
                sqlCommand.Parameters.Add(new SqlParameter("@pirAlert", pir));
                sqlCommand.Parameters.Add(new SqlParameter("@EmailAlert", emailAlert));
                sqlCommand.Parameters.Add(new SqlParameter("@IsAdmin", isAdmin));
                sqlCommand.Parameters.Add(new SqlParameter("@Password", password));
                sqlCommand.Parameters.Add(new SqlParameter("@UserId", userId));
                sqlCommand.ExecuteNonQuery();
                conAlarmDatabase.Close();
                MessageBox.Show("User successfully changed!");// If sucsessfully changed, a messagebox will appear with the message
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

         }
        public string GetMail(int i, string sqlQuery)
        {
            List<string> EmailList = new List<string>();
            string Email = "Feil";
            try
            {
                string Alarm = ConfigurationManager.ConnectionStrings["Alarm"].ConnectionString;
                SqlConnection con = new SqlConnection(Alarm);
                SqlCommand sql = new SqlCommand(sqlQuery, con);
                con.Open();
                SqlDataReader dr = sql.ExecuteReader();
                while (dr.Read() == true)
                {
                    sqlQuery = dr[0].ToString();
                    EmailList.Add(sqlQuery);
                }
                con.Close();
                Email = EmailList[i];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return Email;
        }
        public int EmailSubscribersAmount(string alarmtype)
        {
            try
            {
                string sqlQuery;
                int count = -1;
                if (alarmtype == "PIR")
                {
                    sqlQuery = @"select COUNT(UserId) AS [Antall brukere]
                            from [USER]
                            where [USER].EMailAlert = 1
                            and [USER].PIRAlert = 1";
                    string Alarm = ConfigurationManager.ConnectionStrings["Alarm"].ConnectionString;
                    SqlConnection sqlConnection = new SqlConnection(Alarm);
                    sqlConnection.Open();
                    SqlCommand sqlCommand = new SqlCommand(sqlQuery, sqlConnection);
                    count = (Int32)sqlCommand.ExecuteScalar();
                }
                else if (alarmtype == "BatVolt")
                {
                    sqlQuery = @"select COUNT(UserId) AS [Antall brukere]
                            from [USER]
                            where [USER].EMailAlert = 1
                            and [USER].BatteryVoltageAlert = 1";
                    string Alarm = ConfigurationManager.ConnectionStrings["Alarm"].ConnectionString;
                    SqlConnection sqlConnection = new SqlConnection(Alarm);
                    sqlConnection.Open();
                    SqlCommand sqlCommand = new SqlCommand(sqlQuery, sqlConnection);
                    count = (Int32)sqlCommand.ExecuteScalar();
                }
                else if (alarmtype == "Battery")
                {
                    sqlQuery = @"select COUNT(UserId) AS [Antall brukere]
                            from [USER]
                            where [USER].EMailAlert = 1
                            and [USER].BatteryAlert = 1";
                    string Alarm = ConfigurationManager.ConnectionStrings["Alarm"].ConnectionString;
                    SqlConnection sqlConnection = new SqlConnection(Alarm);
                    sqlConnection.Open();
                    SqlCommand sqlCommand = new SqlCommand(sqlQuery, sqlConnection);
                    count = (Int32)sqlCommand.ExecuteScalar();
                }
                else if (alarmtype == "TempHigh")
                {
                    sqlQuery = @"select COUNT(UserId) AS [Antall brukere]
                            from [USER]
                            where [USER].EMailAlert = 1
                            and [USER].TemperatureHighAlert = 1";
                    string Alarm = ConfigurationManager.ConnectionStrings["Alarm"].ConnectionString;
                    SqlConnection sqlConnection = new SqlConnection(Alarm);
                    sqlConnection.Open();
                    SqlCommand sqlCommand = new SqlCommand(sqlQuery, sqlConnection);
                    count = (Int32)sqlCommand.ExecuteScalar();
                }
                else if (alarmtype == "TempLow")
                {
                    sqlQuery = @"select COUNT(UserId) AS [Antall brukere]
                            from [USER]
                            where [USER].EMailAlert = 1
                            and [USER].TemperatureLowAlert = 1";
                    string Alarm = ConfigurationManager.ConnectionStrings["Alarm"].ConnectionString;
                    SqlConnection sqlConnection = new SqlConnection(Alarm);
                    sqlConnection.Open();
                    SqlCommand sqlCommand = new SqlCommand(sqlQuery, sqlConnection);
                    count = (Int32)sqlCommand.ExecuteScalar();
                }
                else if (alarmtype == "TempError")
                {
                    sqlQuery = @"select COUNT(UserId) AS [Antall brukere]
                            from [USER]
                            where [USER].EM/ailAlert = 1
                            and [USER].TemperatureErrorAlert = 1";
                    string Alarm = ConfigurationManager.ConnectionStrings["Alarm"].ConnectionString;
                    SqlConnection sqlConnection = new SqlConnection(Alarm);
                    sqlConnection.Open();
                    SqlCommand sqlCommand = new SqlCommand(sqlQuery, sqlConnection);
                    //count = (Int32)sqlCommand.ExecuteScalar();
                }
                else
                {
                    count = 0;
                }
                return count;
            }
            catch (SqlException sqlerror)
            {
                //MessageBox.Show("testerror");
                return 0;
            }
        }


    }
}
