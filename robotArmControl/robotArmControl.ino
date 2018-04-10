#define arraySize(x) ((sizeof(x))/(sizeof(x[0])))

#define buttonOn 2
#define buttonOff 3
#define buttonUpdate 13
#define basePin A0
#define shoulderPin A1
#define elbowPin A2
#define wristPin A3
#define gripperPin A4

int buttonOnState = 1;
int buttonOffState = 1;
int buttonUpdateState= 1;
int previousButtonOnState = 1;
int previousButtonOffState = 1;
int previousButtonUpdateState= 1;
int baseValue = 0;
int shoulderValue = 0;
int elbowValue = 0;
int wristValue = 0;
int gripperValue = 0;

bool robotOn = false;

uint8_t inputPin[] = {
  
  buttonOn,
  buttonOff,
  buttonUpdate,
  };



void setup() {

  Serial.begin(9600);

  initInput();
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

void updateInput(){

  buttonOnState = digitalRead(buttonOn);
  buttonOffState = digitalRead(buttonOff);
  buttonUpdateState = digitalRead(buttonUpdate);

  baseValue = analogRead(basePin);
  shoulderValue = analogRead(shoulderPin);
  elbowValue = analogRead(elbowPin);
  wristValue = analogRead(wristPin);
  gripperValue = analogRead(gripperPin);
}

void serialSend(){

  if((previousButtonOnState == 1) && (buttonOnState == 0)){
    previousButtonOnState = buttonOnState;
    if(robotOn){
      Serial.println("Robot is already turn on");
    }else{
      Serial.println("Robot On");
      robotOn = true;
    }
    
    delay(20);
  }
  if((previousButtonOffState == 1) && (buttonOffState == 0)){
    previousButtonOffState = buttonOffState;
    if(robotOn){
      Serial.println("Robot Off");
      robotOn = false;
    }else{
      Serial.println("Robot is already turn off");
    }
    delay(20);
  }
  if((previousButtonUpdateState == 1) && (buttonUpdateState == 0)){
    previousButtonUpdateState = buttonUpdateState;
    if(robotOn){
      Serial.println("Robot Update");
      sendData();
    }else{
      Serial.println("Please turn on robot to update");
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

  baseValue = map(baseValue, 0, 1023, 0, 180);
  shoulderValue = map(shoulderValue, 0, 1023, 0, 180);
  elbowValue = map(elbowValue, 0, 1023, 0, 180);
  wristValue = map(wristValue, 0, 1023, 0, 180);
  gripperValue = map(gripperValue, 0, 1023, 0, 180);

  Serial.print("Base = ");
  Serial.print(baseValue);
  Serial.print("\t");
  Serial.print("Shoulder = ");
  Serial.print(shoulderValue);
  Serial.print("\t");
  Serial.print("Elbow = ");
  Serial.print(elbowValue);
  Serial.print("\t");
  Serial.print("Wrist = ");
  Serial.print(wristValue);
  Serial.print("\t");
  Serial.print("Gripper = ");
  Serial.println(gripperValue);
}

