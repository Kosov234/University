#include <stdlib.h>
#include <stdio.h>
#include <string.h>
char * spacel(char *text) {
  int i;
  for (i = 0;text[i]!=' ';i++ );
  char symb = text[i+1];
  char *ptr = &symb;
  return ptr;
}
int main(){
  char text [11] = "Hello world";
  printf("%c",*spacel(text));
}
