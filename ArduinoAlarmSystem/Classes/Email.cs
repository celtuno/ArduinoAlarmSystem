using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail; 
using ArduinoAlarmSystem.Forms;

namespace ArduinoAlarmSystem
{
    class Email : ISendMail // Implements Interface
    {
        public string Mail; //user login mail
        public string alarmValue; // alarm value
        public string alarmType; //alarm type



        public Email(string T, string V, string M)
        {
            alarmValue = V; //AlarmValue
            alarmType = T; // Type of alarm
            Mail = M; // Mail to send to
        }


        public void SendMail() // Method for sending a mail
        {
            if (alarmType == "Bevegelse") //If alarm = "bevegelse".
            {
                SmtpClient client = new SmtpClient();
                client.Port = 587; //Port
                client.Host = "smtp.gmail.com"; //Mailtype
                client.EnableSsl = true;
                client.Timeout = 10000;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.Credentials = new System.Net.NetworkCredential("AndreasUSNTest@gmail.com", "USNTEST1234");//Login credentials for mail sender 

                MailMessage mail = new MailMessage("AndreasUSNTest@gmail.com", Mail, "Alarm", alarmType + ". Det har blitt oppdaget en bevegelse i hytta"); // mail who should recive what type of alarm.
                mail.BodyEncoding = UTF8Encoding.UTF8;
                mail.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
                


                client.Send(mail); //Send mail
            }
            else
            {
            SmtpClient client = new SmtpClient();
            client.Port = 587; //Port
            client.Host = "smtp.gmail.com"; //Mailtype
            client.EnableSsl = true;
            client.Timeout = 10000;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            client.Credentials = new System.Net.NetworkCredential("AndreasUSNTest@gmail.com", "USNTEST1234");

            MailMessage mail = new MailMessage("AndreasUSNTest@gmail.com", Mail, "Alarm", alarmType + " " + alarmValue); 
            mail.BodyEncoding = UTF8Encoding.UTF8;
            mail.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;

            client.Send(mail); //Send mail
            }
        

        }
    }
}
