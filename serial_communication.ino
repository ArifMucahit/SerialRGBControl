void setup() {
 pinMode(9,OUTPUT);
 pinMode(10,OUTPUT);
 pinMode(11,OUTPUT);
 pinMode(6,OUTPUT);
 pinMode(5,OUTPUT);
 pinMode(3,OUTPUT);
Serial.begin(9600);
}
byte a;
void loop() {
  if(Serial.available()) 
  {
    a= Serial.read();
    switch (a) {
      case '1':
        digitalWrite(9, HIGH);
        break;
      case '2':
        digitalWrite(10, HIGH);
        break;
      case '3':
        digitalWrite(11, HIGH);
        break;
      case '4':
        digitalWrite(5, HIGH);
        break;
      case '5':
        digitalWrite(4, HIGH);
        break;
       case '6':
       digitalWrite(3,HIGH);
    }
       Serial.println(a);     
       delay(1500);   
}


}
