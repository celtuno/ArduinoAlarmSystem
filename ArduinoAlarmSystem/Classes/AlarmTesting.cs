using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace ArduinoAlarmSystem.Classes
{
    class AlarmTesting
    {
        double tempLowParameter, tempHighParameter, tempValue = 20.0, tempErrorParameter;
        int batteryPercentParameter, delayAfterAlarmIsTriggered, batteryPercentValue =50;
        string mail, serialPort;
        bool PIRParameter, ifPowerIsConnected, PIRValue = false;
        public bool alarmValuesRecieved  = false;

        SqlCon sql1 = new SqlCon();


        private void GettingValues()
        {
            try
            {   
                     GlobalData dta = new GlobalData();
                    Arduino A = new Arduino(9600);
                //while (true)
                //{
                    
                    tempValue = dta.getTempC();
                    PIRValue = dta.getmotionBool();

                    PowerStatus p = SystemInformation.PowerStatus;
                    batteryPercentValue = (int)(p.BatteryLifePercent * 100); //gets the current battery percentage on the computer
                    ifPowerIsConnected = (SystemInformation.PowerStatus.PowerLineStatus == PowerLineStatus.Offline); //Checks if battery is connected to power source
                    alarmValuesRecieved = true;
                //}
            }
            catch(Exception error)
            {
                MessageBox.Show("Alarmtesting boot");
                alarmValuesRecieved = false;
            }
        }

        public AlarmTesting(double tempLowParameter, double tempHighParameter, int batteryPercentParameter, bool PIRParameter, double tempErrorParameter, int delayAfterAlarmIsTriggered, string serialPort)
        {
            this.tempLowParameter = tempLowParameter;
            this.tempHighParameter = tempHighParameter;
            this.batteryPercentParameter = batteryPercentParameter;
            this.PIRParameter = PIRParameter;
            this.delayAfterAlarmIsTriggered = delayAfterAlarmIsTriggered;
            this.tempErrorParameter = tempErrorParameter;
            this.serialPort = serialPort;

            Thread updateValueThread = new Thread(GettingValues);
            Thread tempHighThread = new Thread(TempHighTesting);
            Thread tempLowThread = new Thread(TempLowTesting);
            Thread PIRThread = new Thread(PIRTesting);
            Thread battPercentThread = new Thread(BatterypercentTesting);
            Thread battChargerOutThread = new Thread(BatteryChargerOut);
            Thread tempErrorThread = new Thread(TempErrorTesting);

            updateValueThread.Start();
            tempHighThread.Start();
            tempLowThread.Start();
            battPercentThread.Start();
            battChargerOutThread.Start();
            tempErrorThread.Start();

            if(PIRParameter == true)
            PIRThread.Start();
        }
        

        private void TempHighTesting()
        {
            int nrOfUsers = sql1.EmailSubscribersAmount("TempHigh"); //gets the number of users from the database who subscribes to get temphigh alarm

            while (true)
            {
                if (tempValue > tempHighParameter)
                {
                    for (int i = 0; i < nrOfUsers; i++)
                    {
                        mail = sql1.GetMail(i, @"select Email
                                                from [User]
                                                where [User].EMailAlert = 1
                                                and [USER].TemperatureHighAlert = 1");
                        TemperatureAlarm tempAlarm = new TemperatureAlarm(mail, tempValue);
                    }
                    sql1.TempAlarm(tempValue);
                    Console.Beep(5000, 2000);

                    Thread.Sleep(delayAfterAlarmIsTriggered);  //the time it takes for the method to allow a new alarm to be triggered
                }
            }
        }

        private void TempLowTesting()
        {
            int nrOfUsers = sql1.EmailSubscribersAmount("TempLow"); //gets the number of users from the database who subscribes to get templow alarm

            while (true)
            {
                if (tempValue < tempLowParameter)
                {
                    for (int i = 0; i < nrOfUsers; i++)
                    {
                        mail = sql1.GetMail(i, @"select Email
                                                from [User]
                                                where [User].EMailAlert = 1
                                                and [USER].TemperatureLowAlert = 1");
                        TemperatureAlarm tempAlarm = new TemperatureAlarm(mail, tempValue);
                    }
                    sql1.TempAlarm(tempValue);
                    Console.Beep(5000, 2000);

                    Thread.Sleep(delayAfterAlarmIsTriggered);  //the time it takes for the method to allow a new alarm to be triggered
                }
            }
        }

        private void PIRTesting()
        {
            int nrOfUsers = sql1.EmailSubscribersAmount("PIR"); //gets the number of users from the database who subscribes to get PIR alarm

            while (true)
            {
                if (PIRValue == true)
                {
                    for (int i = 0; i < nrOfUsers; i++)
                    {
                        mail = sql1.GetMail(i, @"select Email
                                                from [User]
                                                where [User].EMailAlert = 1
                                                and [USER].PIRAlert = 1");
                        PIR PIRAlarm = new PIR(mail);
                    }
                    sql1.PIRAlarm();
                    Console.Beep(5000, 2000);

                    Thread.Sleep(delayAfterAlarmIsTriggered);  //the time it takes for the method to allow a new alarm to be triggered
                }
            }
        }

        private void BatterypercentTesting()
        {
            int nrOfUsers = sql1.EmailSubscribersAmount("Battery"); //gets the number of users from the database who subscribes to get battery percent alarm alarm

            while (true)
            {
                if (batteryPercentValue < batteryPercentParameter) //checks if the pc battery has a lover percent value than the parameter
                {
                    for (int i = 0; i < nrOfUsers; i++)
                    {
                        mail = sql1.GetMail(i, @"select Email
                                                from [User]
                                                where [User].EMailAlert = 1
                                                and [USER].BatteryAlert = 1");
                        Batterypercent battperc = new Batterypercent(mail, batteryPercentValue);
                    }
                    sql1.BatAlert(batteryPercentValue);
                    Console.Beep(5000, 2000);

                    Thread.Sleep(delayAfterAlarmIsTriggered);  //the time it takes for the method to allow a new alarm to be triggered
                }


            }
        }

        private void BatteryChargerOut()
        {
            int nrOfUsers = sql1.EmailSubscribersAmount("BatVolt"); //gets the number of users from the database who subscribes to get battery charger out alarm

            while (true)
            {
                if (ifPowerIsConnected) //checks to see whether the battery charger is out or not
                {
                    for (int i = 0; i < nrOfUsers; i++)
                    {
                    mail = sql1.GetMail(i, @"select Email
                                                from [User]
                                                where [User].EMailAlert = 1
                                                and [USER].BatteryVoltageAlert = 1");
                    Battery battcharg = new Battery(mail);
                    }

                    sql1.BatteryVoltageAlert(batteryPercentValue);
                    Console.Beep(5000, 2000);

                    Thread.Sleep(delayAfterAlarmIsTriggered);  //the time it takes for the method to allow a new alarm to be triggered

                }


            }
        }

        private void TempErrorTesting()
        {
            int nrOfUsers = sql1.EmailSubscribersAmount("TempError"); //gets the number of users from the database who subscribes to get temperror alarm

            double temp2, tempDifferential;

            temp2 = tempValue;

            while (true)
            {
                tempDifferential = temp2 - tempValue;
                //tempDifferential = 33;
                if (tempDifferential > tempErrorParameter)
                {
                    for (int i = 0; i < nrOfUsers; i++)
                    {
                        mail = sql1.GetMail(i, @"select Email
                                                from [User]
                                                where [User].EMailAlert = 1
                                                and [USER].TemperatureErrorAlert = 1");
                        TemperatureError tempError = new TemperatureError(mail, tempDifferential);
                    }
                    sql1.TempError(tempDifferential);
                    Console.Beep(5000, 2000);

                    Thread.Sleep(delayAfterAlarmIsTriggered);  //the time it takes for the method to allow a new alarm to be triggered
                }
                temp2 = tempValue;
            }
        }
    }
}
