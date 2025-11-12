#include <Servo.h>

Servo servoMotor1;  
Servo servoMotor2;

int pinServo1 = 1;  
int pinServo2 = 2;
int val;    // variable to read the value from the analog pin

void setup() {
  servoMotor1.attach(pinServo1);  
  servoMotor1.write(0); // set servo to initial position
  servoMotor2.attach(pinServo2);
  servoMotor2.write(0);
}

void loop() {
  for(int i = 0; i<180; i++){
    servoMotor1.write(i);
    servoMotor2.write(i);
    delay(15);       
  }
  for(int i = 180; i>0; i--){
    servoMotor1.write(i);
    servoMotor2.write(i);
    delay(15);       
  }
  
                     
}