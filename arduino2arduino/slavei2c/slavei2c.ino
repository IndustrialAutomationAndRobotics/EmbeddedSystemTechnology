#include <Wire.h>

bool state = false;

void setup() {
  Wire.begin(8);
  Wire.onReceive(receiveEvent);
  Serial.begin(9600);
  pinMode(13, OUTPUT);
  
}

void loop() {
  delay(100);
  digitalWrite(13,state);
}

void receiveEvent(int howMany){
  while(1 < Wire.available()){
    char c = Wire.read();
    Serial.print(c);
  }
  int x = Wire.read();
  Serial.println(x);
  state = !state;
}

