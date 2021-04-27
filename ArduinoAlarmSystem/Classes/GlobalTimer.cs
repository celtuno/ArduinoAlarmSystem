using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace ArduinoAlarmSystem
{

    class GlobalTimer

    {
        string[] serialString;
        static int errCount;
        public string newTemp;
        public bool newMotion;
        public double newTempC;
        static bool errorCheck;
        public bool ErrorCheck
        {
            get { return errorCheck; }
        }
        Arduino ardu = new Arduino(9600);


        public GlobalTimer()
        {
            

        }



        public void CheckData()
        {
           
            
            string inData = "";

            inData = ardu.serialData;
            
            serialString = inData.Split('#');
            
            try
            {
                if(serialString.Length <= 1)
                {
                    errCount++;
                    if (errCount >= 5)
                    {
                        errorCheck = true;
                        return;
                    }
                }
                foreach (string data in serialString)

                {
                    //MessageBox.Show("" + serialString[0]);// + " & " + serialString[1]);

                    string TData = serialString[0].Substring(1, 4);
                   
                        
                    
                    TData = TData.Replace('.', ',');
                    //double.TryParse(serialData, out temperature);
                    ardu.temperature = Convert.ToDouble(TData);

                    newTemp = ardu.temperature.ToString();
                    newTempC = ardu.temperature;
                    
                    //Testing
                    //MessageBox.Show("" +newTemp);

                    
                    string MData = serialString[1].Substring(1, 1);
                    //bool.TryParse(MData, out ardu.motion);

                    byte.TryParse(MData, out byte boolData);
                    ardu.motion = Convert.ToBoolean(boolData);
                    

                    newMotion = ardu.motion;
                    
                    //Testing
                    //MessageBox.Show("" +newMotion);
                }
                
                
            }
            catch (Exception error)
            {
                errorCheck = true;
                var resultMsg =  MessageBox.Show("Read error: " + "Cannot read temprature or alarms"+"\r\nClose application?","Connection error",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation);
                if (resultMsg== DialogResult.Yes)
                {
                    Environment.Exit(666);
                }
                else
                {
                    errorCheck = true;
                    
                }

            }


        }

        public void WriteSql()
        {
            //initiate classes and variables 
            Arduino ardu = new Arduino();
            GlobalData dta = new GlobalData();
            //initiate sql 
            SqlCon readIn = new SqlCon();
            double readTemp;
          
            //set 
            //readTemp = ardu.temperature;
            readTemp = dta.getTempC();
            
                if (readTemp != 0)
                {
                //run sql class, calling procedure for writing data to sql

                
                readIn.TempLogging(readTemp);
                
               

                //check for motion alarm trigger value 
                if (ardu.motion == true)
                    {
                        //run sql class, calling procedure for writing data to sql
                        readIn.PIRAlarm();
                    }
                }
            
        }//return temperature (string)
        public string getTemp()
        {
            
            return newTemp;

        }//return temperature (double)
        public double getTempC()
        {

            return newTempC;

        }

        public bool getMotion()
        {

            return newMotion;

        }


    }
    
    
}

