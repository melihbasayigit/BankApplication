#include <Keypad.h>
#include <LiquidCrystal.h>

// Lcd screen 16 x 2
LiquidCrystal lcd(13, 12, 11, 10, 9, 8);

// Keypad
const byte rows = 4;
const byte cols = 3;

char key[rows][cols] = {
  {'1', '2', '3'},
  {'4', '5', '6'},
  {'7', '8', '9'},
  {'*', '0', '#'}
};
byte rowPins[rows] = {21, 20, 19, 18};
byte colPins[cols] = {17, 16, 15};
String password = "0123";
String pw = "";
boolean lockLed = 0;
Keypad keypad = Keypad(makeKeymap(key), rowPins, colPins, rows, cols);
int pos = 0;

// Leds
const int ledredPin = 4;
const int ledgrnPin = 5;
const int ledPin = 23;

// Pir sensor
const int pirPin = 2;
const int lambPin = 6;
int calibrationTime = 30;
long unsigned int lowIn;
long unsigned int _pause = 5000;
boolean lockLow = true;
boolean takeLowTime;
int PIRValue = 0;

// Flame sensor
const int flamePin = 3;
const int buzzerPin = 7;

// Temp Proccess
float temp;
int count = 0;

void setup() {
  // LCD Proccess
  lcd.begin(16, 2);
  lcd.setCursor(0, 0);
  lcd.print("TEMPERATURE IS: ");
  lcd.setCursor(0, 1);
  lcd.print("");

  // PIR proccess
  Serial.begin(9600);
  pinMode(pirPin, INPUT);
  pinMode(lambPin, OUTPUT);

  // Flame proccess
  pinMode(buzzerPin, OUTPUT);

  // Led proccess
  pinMode(ledredPin, OUTPUT);
  pinMode(ledgrnPin, OUTPUT);
  pinMode(ledPin, OUTPUT);

  // Temp proccess
  analogReference(INTERNAL1V1);
}

void loop() {
  TempPros();
  flameSensor();
  PIRSensor();
  if (lockLed != 1) {
    login();
  }
}

void flameSensor() {
  if (digitalRead(flamePin) == HIGH) {
    tone(buzzerPin, 400, 500);
    delay(50);
    tone(buzzerPin, 650, 500);
    delay(50);
  }
  if (digitalRead(flamePin) == LOW) {
    noTone(buzzerPin);
  }
}

void PIRSensor() {
  if (digitalRead(pirPin) == HIGH) {
    digitalWrite(lambPin, HIGH);
    delay(50);
  }
  if (digitalRead(pirPin) == LOW) {
    digitalWrite(lambPin, LOW);
    delay(50);
  }
}

void TempPros() {
  temp = analogRead (A2) ;
  temp = temp * 1100 / (1024 * 10) ;
  lcd.clear();
  lcd.setCursor(0, 0);
  lcd.print ("TEMP:");
  lcd.print (temp) ;
  lcd.println("*C");
  lcd.setCursor(0, 1);
  if (temp < 20) {
    lcd.print("SICAKLIK DUSTU");
  }
  if (temp > 30) {
    lcd.print("SICAKLIK YUKSELDI");
  }
  delay(50);
}

void incorrect() {
  digitalWrite(ledredPin, HIGH);
  digitalWrite(ledgrnPin, LOW);
  delay(50);
}

void correct() {
  digitalWrite(ledredPin, LOW);
  digitalWrite(ledgrnPin, HIGH);
  lockLed = 1;
  delay(50);
}

void login() {
  char code = keypad.getKey();
  if (code != NO_KEY)
  {
    digitalWrite(ledPin, HIGH);
    delay(100);
    digitalWrite(ledPin, LOW);
    pw += code;
    if (pw == password) {
      correct();
      lockLed = 1;
    }
    else if (pos >= 3 && lockLed != 1) {
      incorrect();
    }
    pos++;
  }
  if (code == '*') {
    pw = "";
  }
}