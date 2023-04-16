#define BLYNK_TEMPLATE_ID "TMPL3uLITLYGJ"
#define BLYNK_TEMPLATE_NAME "ArCon"
#define BLYNK_AUTH_TOKEN "RYZTA01LYDi7IgsTnv3xJP_Co5RRGWVS"

#define BLYNK_PRINT Serial
#include<BlynkSimpleEsp8266.h>
#include<ESP8266WiFi.h>

char auth[] = BLYNK_AUTH_TOKEN;
char ssid[] = "nk8";
char password[] = "10042002";

BLYNK_WRITE(V0){
  digitalWrite(D0, param.asInt());
}

BLYNK_WRITE(V1){
  digitalWrite(D1, param.asInt());
}

void setup() {
  pinMode(D0, OUTPUT);
  pinMode(D1, OUTPUT);

  Blynk.begin(auth, ssid, password, "blynk.cloud", 80);
}

void loop() {
  Blynk.run();
}

// https://blynk.cloud/external/api/update?token=RYZTA01LYDi7IgsTnv3xJP_Co5RRGWVS&v1=0 
