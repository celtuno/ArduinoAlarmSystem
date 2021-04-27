using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arbeidskrav_1___Gruppe_4
{
    public class Alarm
    {
        public String alarmType;            //Alarm Type
        public string mail;
        public bool alarmTriggered;         // boolean for if alarm is triggered or not
        public double value = 0;            //the value of the alarm when triggered

        public virtual void AlarmIsTriggered()
        {
            //SQL SQLobject = new SQL();                                   //creates a temporary SQL object for transfering information
            //Email Emailobject = new Email();                             //creates a temporary Email object to send an email to the subscriber
            //SQLobject.SQLtransfering(this.alarmtype, this.value);       //Transfer information when an alarm is triggered to SQL database
            //Email.Emailobject(this.alarmtype, this.value)               //Sends an Email to the user when alarm is triggered
        }
    }

    public class TemperatureAlarm : Alarm
    {
        public TemperatureAlarm(string mail, double temperatureValue, string alarmType = "Temperatur")    //Constructor for creating an object, sets in the needed values
        {
            this.alarmType = alarmType;
            this.value = temperatureValue;
            this.mail = mail;
            AlarmIsTriggered();
        }

        public override void AlarmIsTriggered()    //new override for the method: AlarmIsTriggered
        {
            //SQL SQLobject = new SQL();      
            //Email Emailobject = new Email();
            //SQLobject.temptransfer();
            //Emailobject.SendMail();
        }
    }

    public class PIR : Alarm
    {
        public PIR(string mail, string alarmType = "Bevegelse")          //Constructor for creating an object, sets in the needed values
        {
            this.alarmType = alarmType;
            this.mail = mail;
            AlarmIsTriggered();
        }

        public override void AlarmIsTriggered()      //new override for the method: AlarmIsTriggered
        {
            SqlCon SQLobject = new SqlCon();      
            Email Emailobject = new Email(alarmType, value, mail);
            SQLobject.PIRAlarm();
            Emailobject.SendMail();
        }
    }

    public class Batterypercent : Alarm
    {
        public Batterypercent(string mail, double batteryValue, string alarmType = "Batteri")       //Constructor for creating an object, sets in the needed values
        {
            this.alarmType = alarmType;
            this.value = batteryValue;
            this.mail = mail;
            AlarmIsTriggered();
        }

        public override void AlarmIsTriggered()     //new override for the method: AlarmIsTriggered
        {
            SqlCon SQLobject = new SqlCon();      
            Email Emailobject = new Email(alarmType, value, mail);
            SQLobject.BatAlert(Convert.ToInt32(value));
            Emailobject.SendMail();
        }
    }

    public class Battery : Alarm
    {
        public Battery(string mail, double batteryValue, string alarmType = "Batteri")       //Constructor for creating an object, sets in the needed values
        {
            this.alarmType = alarmType;
            this.value = batteryValue;
            this.mail = mail;
            AlarmIsTriggered();
        }

        public override void AlarmIsTriggered()     //new override for the method: AlarmIsTriggered
        {
            SqlCon SQLobject = new SqlCon();
            Email Emailobject = new Email(alarmType, value, mail);
            SQLobject.BatteryVoltageAlert(Convert.ToInt32(value));
            Emailobject.SendMail();
        }
    }


    public class TemperatureError : Alarm
    {
        public TemperatureError(string mail, double temperatureValue, string alarmType = "Feil på Temp.") //Constructor for creating an object, sets in the needed values
        {                                                                                           
            this.alarmType = alarmType;
            this.value = temperatureValue;
            this.mail = mail;
            AlarmIsTriggered();
        }

        public override void AlarmIsTriggered()     //new override for the method: AlarmIsTriggered
        {
            //SQL SQLobject = new SQL();      
            Email Emailobject = new Email(alarmType, value, mail);
            //SQLobject.Errortransfer(alarmType, value);
            Emailobject.SendMail();
        }
    }

}
