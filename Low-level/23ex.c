#include <stdlib.h>
#include <stdio.h>
#include <string.h>
void zero_tab(int tab[], int size)
{
   int i;
   for(i=0;i<size;i++)
   {
   *(tab+i) = 0;
   }
   for (i=0;i<size;i++)
   {
   printf("%d",*(tab+i));
   }
}
main()
{
   int size = 10;
   int tab[size];
   zero_tab(tab,size);
}