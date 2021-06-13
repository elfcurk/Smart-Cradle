int motorPin[]={4,5,6,7};
int okuyucu=8;
int okunan=HIGH;
char a;
void setup() {
  Serial.begin(9600);
  pinMode(okuyucu,INPUT);
  pinMode(motorPin[0],OUTPUT);
  pinMode(motorPin[1],OUTPUT);
  pinMode(motorPin[2],OUTPUT);
  pinMode(motorPin[3],OUTPUT);
  
}
void MotorCevir(void);
void loop() {
  okunan=digitalRead(okuyucu);
  if(okunan==0)
  {
    Serial.println("Uyandi");
    while(1){
      if(Serial.available())
      {
        delay(5);
        a=Serial.read();
      }
      if(a=='T'){
        MotorCevir();
        break;
      }
    }
  }
  a='l';
}
void MotorCevir()
{/*
  for(int i=0;i<100;i++)
  {
    if(i%4==0)
    digitalWrite(motorPin[0],HIGH);
    else
    digitalWrite(motorPin[0],LOW);
    
    if(i%4==1)
    digitalWrite(motorPin[1],HIGH);
    else
    digitalWrite(motorPin[1],LOW);
    
    if(i%4==2)
    digitalWrite(motorPin[2],HIGH);
    else
    digitalWrite(motorPin[2],LOW);
    
    if(i%4==3)
    digitalWrite(motorPin[3],HIGH);
    else
    digitalWrite(motorPin[3],LOW);
    delay(10);
  }*/
  /*
  digitalWrite(motorPin[0],HIGH);
  digitalWrite(motorPin[1],LOW);
  digitalWrite(motorPin[2],LOW);
  digitalWrite(motorPin[3],LOW);
  delay(100);
  digitalWrite(motorPin[0],LOW);
  digitalWrite(motorPin[1],HIGH);
  digitalWrite(motorPin[2],LOW);
  digitalWrite(motorPin[3],LOW);
  delay(100);
  digitalWrite(motorPin[0],LOW);
  digitalWrite(motorPin[1],LOW);
  digitalWrite(motorPin[2],HIGH);
  digitalWrite(motorPin[3],LOW);
  delay(100);
  digitalWrite(motorPin[0],LOW);
  digitalWrite(motorPin[1],LOW);
  digitalWrite(motorPin[2],LOW);
  digitalWrite(motorPin[3],HIGH);
  */

  for(int i=0;i<100;i++){
    
  digitalWrite(motorPin[0],HIGH);
  digitalWrite(motorPin[1],LOW);
  digitalWrite(motorPin[2],LOW);
  digitalWrite(motorPin[3],LOW);
  
  delay(100);
  
  digitalWrite(motorPin[0],HIGH);
  digitalWrite(motorPin[1],HIGH);
  digitalWrite(motorPin[2],LOW);
  digitalWrite(motorPin[3],LOW);

  delay(100);
  
  digitalWrite(motorPin[0],LOW);
  digitalWrite(motorPin[1],HIGH);
  digitalWrite(motorPin[2],LOW);
  digitalWrite(motorPin[3],LOW);

  delay(100);
  
  digitalWrite(motorPin[0],LOW);
  digitalWrite(motorPin[1],HIGH);
  digitalWrite(motorPin[2],HIGH);
  digitalWrite(motorPin[3],LOW);

  delay(100);
  
  digitalWrite(motorPin[0],LOW);
  digitalWrite(motorPin[1],LOW);
  digitalWrite(motorPin[2],HIGH);
  digitalWrite(motorPin[3],LOW);

  delay(100);

  digitalWrite(motorPin[0],LOW);
  digitalWrite(motorPin[1],LOW);
  digitalWrite(motorPin[2],HIGH);
  digitalWrite(motorPin[3],HIGH);

  delay(100);

  
  digitalWrite(motorPin[0],LOW);
  digitalWrite(motorPin[1],LOW);
  digitalWrite(motorPin[2],LOW);
  digitalWrite(motorPin[3],HIGH);

  delay(100);

  digitalWrite(motorPin[0],HIGH);
  digitalWrite(motorPin[1],LOW);
  digitalWrite(motorPin[2],LOW);
  digitalWrite(motorPin[3],HIGH);
  
  delay(100);
  
  }
}


