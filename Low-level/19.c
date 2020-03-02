#include <stdlib.h>
#include <stdio.h>
#include <string.h>
   void last_char(char text[]){
   int i;
   for (i=0;text[i+1]!='\0';i++);
    char lastch=text[i];
   for (i=0;text[i+1]!=0;i++)
   {
      text[i] = lastch;
   }
}
int main(){
   char text[3] = {'a','b'};
   last_char(text);
   int i;
   for (i = 0;text[i]!=0;i++)
   {
      printf("%c\n",text[i]);
   }
}
