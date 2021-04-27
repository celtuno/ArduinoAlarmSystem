using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.Ports;
using System.Threading.Tasks;

namespace Arbeidskrav_1___Gruppe_4
{
    class SerialCom
    {
        SerialPort Arduino = new SerialPort();
        //set

        string[] validData;
        double temperature;
        public bool alarm;
        public string[] ports;
        string errorMsg;

        public SerialCom()
        {
            getPorts();
        }
        public SerialCom(string comport, int baudrate)
        {
            //set upcomport and baudrate for communication with arduino
            Arduino.PortName = comport;
            Arduino.BaudRate = baudrate;
            //SerialPort newPorts = new SerialPort();
            Arduino.ReadTimeout = 1000;
            //start reading serial
            ReadSerial();
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
            Arduino.Open();
            //write to arduino initiating communication

            Arduino.Write(buffer, 0, buffer.Length);
            //newPort.Write(buffer, 0, buffer.Length);
            //Thread.Sleep(500); //Wait 0.5 seconds
        }

        public void ReadSerial()
        {

            string newData;
            bool testRead = false;
            //SerialPort newPort = new SerialPort(port, 9600);
            try
            {
                initiateSerial();
                //read bytes ready from arduino
                int countData = Arduino.BytesToRead;


                //if no data - set message
                if (countData <= 0)
                {
                    testRead = false;
                }
                else    //if data is found
                {
                    testRead = true;
                    while (countData > 0) //whila data is available
                    {


                        newData = Arduino.ReadLine();


                        if (newData.Contains("Temp"))  //check for temperature reading
                        {
                            validData[0] = newData.Substring(5);

                            temperature = Convert.ToDouble(validData[0]);

                        }
                        else if (newData.Contains("Move"))  //Check for movement on pir sensor 
                        {
                            validData[1] = newData.Substring(5);
                            alarm = Convert.ToBoolean(validData[1]);
                        }
                        else//For Testing
                        {

                        }
                        countData--;

                    }
                }

            }


            catch (Exception e)
            {

            }

        }
        //close comport when program ends
        ~SerialCom()
        {
            Arduino.Close();
        }

        //get all available com-ports on the computer
        private void getPorts()
        {


            ports = SerialPort.GetPortNames();
            //foreach(string port in ports)



        }
        public void WriteSerial(string port, int command, int buffer)
        {
            //SerialPort newPort = new SerialPort(port, 9600);
            byte[] writeByte = new byte[buffer];

            try
            {
                Arduino.Open();
                //newPort.Open();
                for (int i = 0; i < buffer; i++)
                {
                    char[] test = new char[1];
                    test[i] = Convert.ToChar(writeByte[i]);
                    Arduino.Write(test, 0, buffer);

                }

            }
            catch (NullReferenceException noPortSelected)
            {
                errorMsg = noPortSelected.ToString();

            }
            catch (Exception errorCom)
            {
                errorMsg = errorCom.ToString();
                
            }
            
        }


    }
}
