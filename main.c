#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <stdbool.h>
#define INPUT "input.txt"
#define MAX_CHAR 256
#define MAX_LINE 300

struct bigO
{
    char name; 
    int katsayi; 
    int ust; 
    bool isLog; // Logaritmik mi 
    bool isUstel;
    char Ustel;
};

typedef struct bigO bigO;

FILE * globalFile;
char * codeStr;
int bigONotMatris[MAX_LINE][15];
char fordongusu[] = "for";
char whiledongusu[] = "while";

void preLoading() {
    codeStr = malloc(sizeof(char) * MAX_CHAR);
    for (int i = 0; i < MAX_LINE; i++)
    {
        for (int j = 0; j < 15; j++)
        {
            bigONotMatris[i][j] = 0;
        }
    }
}

void printText() {
    // Read and print code.
    if((globalFile = fopen(INPUT, "r")) == NULL) {
        printf("Dosya acilamadi problem var.\n");
        exit(1);
    }
    printf("KODUNUZ OKUNUYOR... \\ \\ \\ \n. \n. \n");
    printf("KODUNUZ YAZDIRILIYOR... \\ \\ \\ \n \n");
    printf("//////////////////////////////\n");
    while (fgets(codeStr, MAX_CHAR, globalFile) != NULL) {
        printf("%s",codeStr);
    }
    printf("//////////////////////////////\n");
    fclose(globalFile);
}

void bigOCheck() {
    if((globalFile = fopen(INPUT, "r")) == NULL) {
        printf("Dosya acilamadi problem var.\n");
        exit(1);
    }

    printf("KODUNUZ BIG O ZAMAN NOTASYONU YAPILIYOR ... \\ \\ \\ \n. \n. \n");
    printf("//////////////////////////////\n");
    int index = 0;
    while (fgets(codeStr, MAX_CHAR, globalFile) != NULL) {
        if(strstr(codeStr,fordongusu)) {
            for (int i = 0; i < MAX_LINE; i++)
            {
                if(bigONotMatris[i][index] == 0) {
                    // CHECK FOR LOOP TYPE
                    bigONotMatris[i][index] = 1;
                }

            }
            
        }
    }
    fclose(globalFile);
}

int main(int argc, char *argv[]) {
    preLoading();
    bigO bigO_line1, bigO_line2;
    printText();
    bigOCheck();
    return 0;
}