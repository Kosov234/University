#include <stdlib.h>
#include <stdio.h>
#include <string.h>
void mx_tab(float tab[],int size,float *min,float *max)//(float *tab,
{
   float *p;//int i;
   *min = *max = tab[0];//*tab;
   for(p=tab+1;p<tab+size;p++)//(i=1;i<size;i++)
   {
      if(*p<*min)//(tab[i]<*min)
         *min=*p;//tab[i]
      if(*p>*max)//(tab[i]>*max)
         *max=*p;//tab[i]
   }
}
   void mx_tab2(float tab[],int size,float **min,float **max)
{
   float *p;
   *min = *max = tab;
   for(p=tab+1;p<tab+size;p++)
   {
      if(*p<**min)
         *min=p;
      if(*p>**max)
         *max=p;
   }
}


int main()
{
   float t1[]={3.3,1.1,5.5,4.4,2.2};
   float *m1,*m2;
   //mx_tab(t1,5,&m1,&m2);
   //printf("minimum is %f and maximum is %f\n",m1,m2);
   mx_tab2(t1,5,&m1,&m2);
   printf("minimum is %f and maximum is %f\n",*m1,*m2);
}