using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ArduinoAlarmSystem
{
    class FileHandling
    {
        
        private string fileName = Directory.GetCurrentDirectory() + "\\Parameters.txt";
        public int tempErrorParameter, readInterval, delayAfterAlarmTrigger;
        public string serialPort;
        

        
        public void FileReader()
        {
            
                FileStream fS = new FileStream(fileName, FileMode.OpenOrCreate);
                fS.Close();
                StreamReader SR = new StreamReader(fileName);
            try
            {

                tempErrorParameter = Convert.ToInt32(SR.ReadLine());
                readInterval = Convert.ToInt32(SR.ReadLine());
                delayAfterAlarmTrigger = Convert.ToInt32(SR.ReadLine());
                serialPort = SR.ReadLine().ToString();
                
                

            }
            catch (Exception e)
            {

            }
            SR.Close();
        }

        public void FileWriter(int tempErrorParameter, int readInterval, int delayAfterAlarmTrigger,string serialPort)
        {
            File.Delete(fileName);

            FileStream fS = new FileStream(fileName, FileMode.OpenOrCreate);
            fS.Close();
            StreamWriter SW = new StreamWriter(fileName);
           
            SW.WriteLine(tempErrorParameter);
            SW.WriteLine(readInterval);
            SW.WriteLine(delayAfterAlarmTrigger);
            SW.WriteLine(serialPort);

            SW.Close();
        }
        public void FileWriter(int tempErrorParameter, int readInterval, int delayAfterAlarmTrigger)
        {
            File.Delete(fileName);

            FileStream fS = new FileStream(fileName, FileMode.OpenOrCreate);
            fS.Close();
            StreamWriter SW = new StreamWriter(fileName);

            SW.WriteLine(tempErrorParameter);
            SW.WriteLine(readInterval);
            SW.WriteLine(delayAfterAlarmTrigger);
            

            SW.Close();
        }
        
    }
}
