#define arraySize(x) ((sizeof(x))/(sizeof(x[0])))

#define buttonOn 2
#define buttonOff 3
#define buttonUpdate 4
#define basePin A0
#define shoulderPin A1
#define elbowPin A2
#define wristPin A3
#define gripperPin A4
#define baseOutputPin 11
#define shoulderOutputPin 10
#define elbowOutputPin 9
#define wristOutputPin 6
#define gripperOutputPin 5

uint32_t baseCode = 49000;
uint32_t shoulderCode = 50000;
uint32_t elbowCode = 51000;
uint32_t wristCode = 52000;
uint32_t gripperCode = 53000;

int buttonOnState = 1;
int buttonOffState = 1;
int buttonUpdateState= 1;
int previousButtonOnState = 1;
int previousButtonOffState = 1;
int previousButtonUpdateState= 1;
int previousBaseValue = 0;
int previousShoulderValue = 0;
int previousElbowValue = 0;
int previousWristValue = 0;
int previousGripperValue = 0;
int baseValue = 0;
int shoulderValue = 0;
int elbowValue = 0;
int wristValue = 0;
int gripperValue = 0;

int mapBaseValue = 0;
int mapShoulderValue = 0;
int mapElbowValue = 0;
int mapWristValue = 0;
int mapGripperValue = 0;

bool robotOn = false;

uint8_t outputPin[] = {

  baseOutputPin,
  shoulderOutputPin,
  elbowOutputPin,
  wristOutputPin,
  gripperOutputPin,
};

uint8_t inputPin[] = {
  
  buttonOn,
  buttonOff,
  buttonUpdate,
  };



void setup() {

  Serial.begin(9600);

  initInput();
  initOutput();

}

void loop() {

  updateInput();
  serialSend();
}

void initInput(){
  for(uint8_t i = 0; i < arraySize(inputPin); i++){
    pinMode(inputPin[i], INPUT_PULLUP);
  }
}

void initOutput(){
  for(uint8_t i = 0; i < arraySize(outputPin); i++){
    pinMode(outputPin[i], OUTPUT);
  }
}

void updateInput(){

  buttonOnState = digitalRead(buttonOn);
  buttonOffState = digitalRead(buttonOff);
  buttonUpdateState = digitalRead(buttonUpdate);

  baseValue = analogRead(basePin);
  shoulderValue = analogRead(shoulderPin);
  elbowValue = analogRead(elbowPin);
  wristValue = analogRead(wristPin);
  gripperValue = analogRead(gripperPin);

  analogWrite(baseOutputPin, map(baseValue, 0, 1023, 0, 255));
  analogWrite(shoulderOutputPin, map(shoulderValue, 0, 1023, 0, 255));
  analogWrite(elbowOutputPin, map(elbowValue, 0, 1023, 0, 255));
  analogWrite(wristOutputPin, map(wristValue, 0, 1023, 0, 255));
  analogWrite(gripperOutputPin, map(gripperValue, 0, 1023, 0, 255));

  mapBaseValue = map(baseValue, 0, 1023, 0, 180);
  mapShoulderValue = map(shoulderValue, 0, 1023, 0, 180);
  mapElbowValue = map(elbowValue, 0, 1023, 0, 180);
  mapWristValue = map(wristValue, 0, 1023, 0, 180);
  mapGripperValue = map(gripperValue, 0, 1023, 0, 180);
}

void serialSend(){

  if((previousButtonOnState == 1) && (buttonOnState == 0)){
    previousButtonOnState = buttonOnState;
    if(robotOn){
      //Serial.println("Robot is already turn on");
    }else{
      //Serial.println("Robot On");
      Serial.println(89);
      robotOn = true;
    }
    
    delay(20);
  }
  if((previousButtonOffState == 1) && (buttonOffState == 0)){
    previousButtonOffState = buttonOffState;
    if(robotOn){
      //Serial.println("Robot Off");
      Serial.println(78);
      robotOn = false;
    }else{
      //Serial.println("Robot is already turn off");
    }
    delay(20);
  }
  if((previousButtonUpdateState == 1) && (buttonUpdateState == 0)){
    previousButtonUpdateState = buttonUpdateState;
    if(robotOn){
      //Serial.println("Robot Update");
      sendData();
    }else{
      //Serial.println("Please turn on robot to update");
    }
    delay(20);
  }
  if((previousButtonOnState == 0) && (buttonOnState == 1)){
    previousButtonOnState = buttonOnState;
    delay(20);
  }
  if((previousButtonOffState == 0) && (buttonOffState == 1)){
    previousButtonOffState = buttonOffState;
    delay(20);
  }
  if((previousButtonUpdateState == 0) && (buttonUpdateState == 1)){
    previousButtonUpdateState = buttonUpdateState;
    delay(20);
  }
}

void sendData(){

  if(previousBaseValue != mapBaseValue){
    previousBaseValue = mapBaseValue;
    Serial.println(baseCode + mapBaseValue);
  }
  if(previousShoulderValue != mapShoulderValue){
    previousShoulderValue = mapShoulderValue;
    Serial.println(shoulderCode + mapShoulderValue);
  }
  if(previousElbowValue != mapElbowValue){
    previousElbowValue = mapElbowValue;
    Serial.println(elbowCode + mapElbowValue);
  }
  if(previousWristValue != mapWristValue){
    previousWristValue = mapWristValue;
    Serial.println(wristCode + mapWristValue);
  }
  if(previousGripperValue != mapGripperValue){
    previousGripperValue = mapGripperValue;
    Serial.println(gripperCode + mapGripperValue);
  }
}

