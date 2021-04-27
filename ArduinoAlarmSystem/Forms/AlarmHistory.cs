using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Configuration;
using System.Data.SqlClient;
using ArduinoAlarmSystem.Forms;

namespace ArduinoAlarmSystem
{
    public partial class AlarmHistory : Form
    {
        public DataTable dataTable = new DataTable();
        public AlarmHistory()
        {
            InitializeComponent();
            try
            {
                string sqlQuery = @"select * from Alarms Order By AlarmId ASC";
                string Alarm = ConfigurationManager.ConnectionStrings["Alarm"].ConnectionString;
                //SqlCon sqlCon = new SqlCon();
                SqlConnection con = new SqlConnection(Alarm);
                SqlDataAdapter sda;
                DataTable dt;
                con.Open();
                sda = new SqlDataAdapter(sqlQuery, con);
                dt = new DataTable();
                sda.Fill(dt);
                dgvAlarmHistory.DataSource = dt;
                con.Close();                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void btnBackAlarmhistorikk_Click(object sender, EventArgs e)
        {
            this.Close(); //Closes Form
        }

        private void btnMailPDF_Click(object sender, EventArgs e)
        {
            bool SendMail = false;

            try
            {
            PDF pDF = new PDF();
            pDF.CreatePDF(); //Creates an PDF file(need to send values)
            }
            catch (Exception)
            {
               
                MessageBox.Show("Email already sent");
                SendMail = true;
            }


            //---------------------------------------------------------------------------
            
            using (SqlConnection sqlConn = new SqlConnection(ConfigurationManager.ConnectionStrings["Alarm"].ConnectionString))
            {
                string sqlQuery = "Select EMail from [USER] where EMailAlert = 'True' ";
                using (SqlCommand cmd = new SqlCommand(sqlQuery, sqlConn))
                {
                    SqlDataAdapter dr = new SqlDataAdapter(cmd);
                    dr.Fill(dataTable);
                }
            }

            if (SendMail == false)
            {
                foreach (DataRow dr in dataTable.Rows) //Finds all values 
                {

                string Mails = (string)dr[0]; //Values in AlarmId


                SmtpClient client = new SmtpClient();
                client.Port = 587; //Port
                client.Host = "smtp.gmail.com"; //Mailtype
                client.EnableSsl = true;
                client.Timeout = 10000;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.Credentials = new System.Net.NetworkCredential("AndreasUSNTest@gmail.com", "USNTEST1234");//Login credentials for mail sender 

                MailMessage mail = new MailMessage("AndreasUSNTest@gmail.com", Mails, "Alarm", "Alarm historikk." + "\n" + "Her ligger alarmhistorikken som et vedlegg."); // mail who should recive mailtype and what type of alarm.
                mail.BodyEncoding = UTF8Encoding.UTF8;
                mail.Attachments.Add(new Attachment("D:\\PDF ALARMS.pdf")); //Puts the PDF Alarm history as an attachment
                mail.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;

                client.Send(mail); //Send mail

                }

            }
            else
            {
                return;
            }


            
        }

        private void dgvAlarmHistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
