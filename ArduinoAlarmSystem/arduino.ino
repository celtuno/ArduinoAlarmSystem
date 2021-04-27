//incude driver for neopixel adressable led
#include <Adafruit_NeoPixel.h>
#define LEDPIN 8
#define NUM_OF_LEDS 8
Adafruit_NeoPixel strip = Adafruit_NeoPixel(NUM_OFO_LEDS, LEDPIN, NEO_GRB + NEO_KHZ800)

//TMP36 Pin Variables
int temperaturePin = 1; //the analog pin the TMP36's Vout (sense) pin is connected to
                        //the resolution is 10 mV / degree centigrade with a
                        //500 mV offset to allow for negative temperatures
int tempReadDelay = 500 


/* 
 * setup() - this function runs once when you turn your Arduino on
 * We initialize the serial connection with the computer
 */

void setup()
{
  Serial.begin(9600);  //Start the serial connection with the computer
                       //to view the result open the serial monitor 
  strip.begin();
  strip.show(); // Initialize all pixels to 'off'
  strip.setPixelColor(7, 0, 0x16, 0);
}
 
void loop()                     // run over and over again
{
 //getting the voltage reading from the temperature sensor
 
 
 
 bool alarm;
checkDataIn();
readTemp();
readMotion();
Serial.print(str(alarm));




 
 delay(tempReadDelay);                                     //waiting a second
}
void readTemp(){ 
    
   //________________Temperature_____________________
   int temp= analogRead(temperaturePin);  
  
   // converting that reading to voltage, for 3.3v arduino use 3.3
   float voltage = reading * 5;
   voltage /= 1024.0; 
   
   // print out the voltage
   //Serial.print(voltage); Serial.println(" volts");
   
  
   float temperatureC = (voltage - 0.5) * 100 ;  //converting from 10 mv per degree wit 500 mV offset
                                                 //to degrees ((voltage - 500mV) times 100)
   //Print temperature
   Serial.print("Temp");
   Serial.print(temperatureC); Serial.println(" degrees C");
   
  }

void readMotion(){
   //___________Motion____________
  byte  motion = digitalRead(motionPin);
  if (motion >0){
    motionDetected = true;
    
      
  }
  else{
    motionDetected = true;
    alarmAlarmActive();
  }
  
  
  Serial.print("Motion");
  Serial.print(motionDetected)
}
void alarmActive{
  if (motionDetected = true){
    alarm = true;
    strip.setPixelColor(7, 0x16, 0, 0);
  }
}

//Change tempterature read intervall
void checkDataIn(){
  int availableByte=0;
  availableByte = Serial.available();
  int readByte = 0;
  for(int i = 0:i<availableByte;i++){
    readByte = Serial.read();
    allBytes[i]=readByte;
  }
  if (allBytes[1] = 111){
    alarm = false;
  }
  else{
    
  }
}





 

 
