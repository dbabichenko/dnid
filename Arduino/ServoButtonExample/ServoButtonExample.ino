/* Sweep
 by BARRAGAN <http://barraganstudio.com>
 This example code is in the public domain.

 modified 8 Nov 2013
 by Scott Fitzgerald
 https://www.arduino.cc/en/Tutorial/LibraryExamples/Sweep
*/

#include <Servo.h>

Servo myservo;  // create Servo object to control a servo
Servo myservo1;  // create Servo object to control a servo

// twelve Servo objects can be created on most boards

int pos = 0;    // variable to store the servo position
const int buttonPin = 5;
int buttonState = 0;  // variable for reading the pushbutton status

void setup() {
  myservo.attach(2);  // attaches the servo on pin 9 to the Servo object
  myservo1.attach(3);  // attaches the servo on pin 9 to the Servo object

  pinMode(buttonPin, INPUT);
}

void loop() {
  buttonState = digitalRead(buttonPin);

  if (buttonState == HIGH) {
    for (pos = 0; pos <= 180; pos += 1) { // goes from 0 degrees to 180 degrees
      // in steps of 1 degree
      myservo.write(pos);              // tell servo to go to position in variable 'pos'
      myservo1.write(pos);              // tell servo to go to position in variable 'pos'
      delay(15);                       // waits 15 ms for the servo to reach the position
    }
  
    for (pos = 180; pos >= 0; pos -= 1) { // goes from 180 degrees to 0 degrees
      myservo.write(pos);              // tell servo to go to position in variable 'pos'
      myservo1.write(pos);              // tell servo to go to position in variable 'pos'
      delay(15);                       // waits 15 ms for the servo to reach the position
    }
  }
    
}
