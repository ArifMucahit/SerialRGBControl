void setup() {
Serial.begin(9600);
}
short led,brightness;

void loop() {
 if(Serial.available())
    {     
       int data=Serial.parseInt(); // take the data came from c# app
       led = data / 1000; // dive to 1000 to get pin number
       brightness = data %1000; // mode to 1000 to get shineness
       if(data > 30000) // the unique data for close off.
       {
        for(int i=0; i <= 12; i++)
           analogWrite(i,LOW);
       } 
       Serial.println(data); 
       if (Serial.read() == '\n') // if the data is not null
       {
        shineIt(led,parlaklik); // shine it up ! 
       } 
     }
     
}
  void shineIt(short led,short bright)
  {
    analogWrite(led,bright); // give the voltage to the pin.
  }

