using ArduinoAlarmSystem.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using ArduinoAlarmSystem.Classes;
//using System.Timers;

namespace ArduinoAlarmSystem
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        //Initiate Timer
        static System.Threading.Timer testingTimer;
        static GlobalTimer timerClass = new GlobalTimer();
        static FileHandling FH = new FileHandling();
        
        
        [STAThread]
        
        
        static void Main()
        {

            //Activate timer

            //5000 = 5 seconds
            

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new MenyAfterLogin());
            //Application.Run(new CurrentValues());
            


            Cursor.Current = Cursors.WaitCursor;
            //initiate sql class
            SqlCon sc = new SqlCon();
            //FileHandling FH = new FileHandling();
            FH.FileReader();
            alarmLimits al = sc.GetAlarmLimits();
            if (al.alarmLimitsSet)
            {
                AlarmTesting at = new AlarmTesting(al.tempLow, al.tempHigh, al.battPercent, al.PIR, FH.tempErrorParameter, FH.delayAfterAlarmTrigger, FH.serialPort);
            }

            
            //read timer intervall from file
            
            testingTimer = new System.Threading.Timer(new System.Threading.TimerCallback(TickTimer), null, 10000,5000);

            int timerTime = Convert.ToInt16(FH.readInterval);
            testingTimer.Change(5000, timerTime);
            //Read all changeable settings from file

            //FileHandling FH = new FileHandling();
            //FH.FileStreamer();
            
            Application.Run(new Login());

        }
        //Timer fore reading serial in backgriound
        //Also writes to sql
        static void TickTimer(object state)
            {
            //check for errors'
            if (!timerClass.ErrorCheck)
            {

                //check for recieved data

                timerClass.CheckData();
                //write data to sql
                if (!timerClass.ErrorCheck)
                {
                    timerClass.WriteSql();
                    //Send temperature and motion to Glabaldata class
                    GlobalData dta = new GlobalData(timerClass.getTemp(), timerClass.newMotion, timerClass.newTempC);
                }
            }
            else
            {
                MessageBox.Show("No connections to anything stopping timers", "Full stop erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Cursor.Current = Cursors.Default;
                testingTimer.Dispose();
            }


        }


    }
}
