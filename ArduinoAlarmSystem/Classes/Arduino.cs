using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Windows.Forms;

namespace ArduinoAlarmSystem
{
     class Arduino
    {
        
       
        SerialPort SerialArduino = new SerialPort();
       
        //set variables for serial connection
        public bool motion;
        public double temperature = 0.1;
        

        public string serialData = "";
        public string COMport;
        public bool dataReady { get; set; }
        //public bool alarm;
        public string[] ports;
      
      
        

        public Arduino()
        {
            //Get all available port, and stores into array
            getPorts();
            
        }
        
        //Initiate arduino class and set baudrate for communication with arduino
        public Arduino(int baudrate)
        {
             SerialArduino.BaudRate = baudrate;
            //Timeout for reading serial data
            SerialArduino.ReadTimeout = 1000;

            //Read chosen serialport
            
            getPorts();
            try
            {
                string testport = ports[0];
                COMport = testport;
            }
            catch
            {


            }
            

            if (COMport != null)
            {
                
                 SerialArduino.PortName = COMport;
            
            }
            else
            {
                //set standard comport
               SerialArduino.PortName = "COM7";

            }
           
            
            //start reading serial
            ReadSerial();
            

        }
       

        
        //get all available com-ports on the computer
        private void getPorts()
        {
            ports = SerialPort.GetPortNames();
            //foreach(string port in ports)
        }
        
        //-OBSOLETE - AUTO CLOSE ARDUINO CLASS
        /*~Arduino()
        {
            SerialArduino.Close();
        }
        */

        //Check if data is recieved/ready, -used by Globaltimer/Backgroundtimer
        public void DataRecieved(object sender, SerialDataReceivedEventArgs earg)
        {

            try
            {
                //Read arduino via serial
                serialData = SerialArduino.ReadLine();
                dataReady = true;
            }
            catch(Exception error)
            {
                dataReady = false;
               MessageBox.Show("error: " + error.Message);
            }

        }
        private void initiateSerial()
        {
            // bytes to send to initiate communication with arduino
            byte[] buffer = new byte[5];
            buffer[0] = Convert.ToByte(16);
            buffer[1] = Convert.ToByte(128);
            buffer[2] = Convert.ToByte(0);
            buffer[3] = Convert.ToByte(0);
            buffer[4] = Convert.ToByte(4);
            try
            {
                //Open serial port for arduino communication
                SerialArduino.Open();
                
                //write to arduino initiating communication
                SerialArduino.Write(buffer, 0, 5);
                //newPort.Write(buffer, 0, buffer.Length);
                //Thread.Sleep(500); //Wait 0.5 seconds
            }
            catch (Exception error)
            {
               // MessageBox.Show("Init COM error: " + error.Message + "\r\n" + "Cannot read temprature or alarms","Connection error",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);

            }
        }
        public void ReadSerial()
        {
            

            try
            {

                //Use eventhandler to check if data is recieved
                SerialArduino.DataReceived += new SerialDataReceivedEventHandler(DataRecieved);
                //Check if serialport is open
                if (!SerialArduino.IsOpen)
                {
                    initiateSerial();
                }
                dataReady = false;

                
            }
            catch (NullReferenceException eNull)
            {
               // MessageBox.Show("Error: " + eNull.Message);
            }
            catch (Exception e)
            {
               // MessageBox.Show("Error: " + e.Message);
            }
        }
        //close comport when program ends
      
        public void WriteSerial(string port, int command, int buffer)
        {
            
            //writes data to serial / initiates serial communication
            byte[] writeByte = new byte[buffer];
            try
            {
                SerialArduino.Open();
            
                for (int i = 0; i < buffer; i++)
                {
                    char[] test = new char[1];
                    test[i] = Convert.ToChar(writeByte[i]);
                    SerialArduino.Write(test, 0, buffer);
                }
            }
            catch (NullReferenceException noPortSelected)
            {
               // MessageBox.Show("Com error: " + noPortSelected.Message);
            }
            catch (Exception errorNoCom)
            {
               // MessageBox.Show("Error: " + errorNoCom.Message);
            }
        }

        //Manually stop arduino class(reading serial)
        public Arduino(bool stop)
        {
            if (stop == true)
            {
                SerialArduino.Close();
            }

        }
    

    
    }
}
