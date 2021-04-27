using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArduinoAlarmSystem
{
    class GlobalData
    {

        //Initiate variables for temp and motion, default value
        static string temp;// ="N/A";
        static string motion;// = "N/A";
        static double tempC = 0.1;
        static bool motionBool;
        
        public GlobalData()
        {
        
        }
        public GlobalData(string tmp,bool mot, double tmpC)
        {
                //Read and save variables from timer/arduino
          
                temp = tmp;
                tempC = tmpC;
            motionBool = mot;

            motion = Convert.ToString(mot);
            

            //MessageBox.Show("" + temp);
            
        }
  

        //return temperature(string)
        public string getTemp()
        {
           
            return temp;
        }
        //return motion(string)
        public string getMotion()
        {
             
            return motion;
        }//return temperature(double)
        public double getTempC()
        {

            return tempC;
        }
        public bool getmotionBool()
        {
            return motionBool;
        }

      




    }
}
