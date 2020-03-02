#include <stdlib.h>
#include <stdio.h>
#include <string.h>
void reverse_word(char text[])
{
   int space;
   for(space=0;text[space]!=' ';space++);
   if(text[space+1]==' ')
   {space+=2;}
   else 
   {space++;}
   int space2;
   for(space2=space;text[space2]!=' '&&text[space2]!='\0';space2++);
   int i;
   int buffer;
   for(i=0;i<=(space2-space)/2;i++)
   {
      buffer = *(text+space2-i);
      *(text+space2-i)=*(text+space+i);
      *(text+space+i)=buffer;
   }
}
main()
{
   char text[]="AnnMartha Martha";
   reverse_word(text);
   int i;
   for(i=0;i<sizeof(text)-1;i++)
   {
   printf("%c",text[i]);
   }
}