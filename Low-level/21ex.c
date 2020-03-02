#include <stdlib.h>
#include <stdio.h>
#include <string.h>
int palindrome(char text[])
{
   int size;
   for (size=0;text[size]!='\0';size++);
   int i;
   for (i=0;i<size/2;i++)
   {
   if ((text[i]!=text[size-1-i])&&(abs(text[i]-text[size-1-i])!=32))
   {return 0;}
   }
   return 1;
}
main()
{
   char text[] = "Br rb";
   printf("%d",palindrome (text));
}