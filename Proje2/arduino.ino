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
char* password = "0123";
int currentposition = 0;
Keypad keypad = Keypad(makeKeymap(key), rowPins, colPins, rows, cols);

// Leds
const int ledredPin = 4;
const int ledgrnPin = 5;

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
boolean flameBegin = false;
boolean breakSensor = false;

// Temperature sensor
const int tempPin = 0;

void setup() {
  // LCD Proccess
  lcd.begin(16, 2);
  lcd.setCursor(0, 0);
  lcd.print("TEMPERATURE IS: ");
  lcd.setCursor(0, 1);
  lcd.print("22.97");

  // PIR proccess
  Serial.begin(9600);
  pinMode(pirPin, INPUT);
  pinMode(lambPin, OUTPUT);

  // Flame proccess
  pinMode(buzzerPin, OUTPUT);

  // Led proccess
  pinMode(ledredPin, OUTPUT);
  pinMode(ledgrnPin, OUTPUT);
}

void loop() {
  if (digitalRead(flamePin) == HIGH && flameBegin == false) {
    flameBegin = true;
  }
  flameSensor();
  PIRSensor();
  TempPros();

  char code = keypad.getKey();
  if (code != NO_KEY)
  {
    lcd.clear();
    lcd.setCursor(0, 0);
    lcd.print("PASSWORD:");
    lcd.setCursor(7, 1);
    lcd.print(" ");
    lcd.setCursor(7, 1);
    for (int i = 0; i <= currentposition; ++i)
    {
      lcd.print("*");
    }

    if (code == password[currentposition])
    {
      ++currentposition;
      if (currentposition == 4)
      {

        correct();
        currentposition = 0;

      }

    }


    else
    {
      incorrect();
      currentposition = 0;

    }
  }












}

void flameSensor() {
  if (flameBegin == true && breakSensor == false) {
    breakSensor = true;
    delay(10);
  }
  if (flameBegin == true && breakSensor == true) {
    tone(buzzerPin, 400, 500);
    delay(50);
    tone(buzzerPin, 650, 500);
    delay(50);
  }
  if (digitalRead(flamePin) == LOW) {
    breakSensor = false;
    flameBegin = false;
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
  int vout=analogRead(tempPin);
  vout = (vout*4.88) / 10;
  int tempc = vout;
  Serial.print("Temature is: ");
  Serial.println(tempc);
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
  delay(50);
}