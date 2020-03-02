#include <stdlib.h>
#include <stdio.h>
#include <string.h>
float* copy_tab(float tab[],int size)
{
float*ptr;
int i;
ptr=malloc(size*sizeof(float));
for(i=0;i<size;i++)
{
ptr[i]=tab[i];
}
return ptr;
}
main ()
{
float tab[]={7};
printf("%f",*copy_tab(tab,sizeof(tab)));
}