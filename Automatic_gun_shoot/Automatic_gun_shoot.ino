#include <Servo.h>

Servo servo1;
void setup() {
  // put your setup code here, to run once:
  servo1.attach(10);
  Serial.begin(9600);

}

void loop() {
  // put your main code here, to run repeatedly:
int val;
if (Serial.available()){
  delay(10);
  while(Serial.available()>0){
    val=Serial.read();
    if(val=='0')
    {
    servo1.write(-180);
    delay(1250);
    servo1.write(180);}
     if(val=='1')
     {delay(10);
    servo1.write(90);}
  }
}
}
