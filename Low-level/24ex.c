#include <stdlib.h>
#include <stdio.h>
#include <string.h>
double* copy_var(double v)
{
double*ptr;
ptr=malloc(sizeof(double));
*ptr=v;
return ptr;
}
main ()
{
double v = 5;
printf("%d\n",copy_var(v));
printf("%d",&v);
}