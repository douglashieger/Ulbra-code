#include<stdio.h>
#include<conio.h>

main ( ){


float n1,n2,media;
printf("nota 1:");
scanf("%f",&n1);
printf("\nnota 2:");
scanf("%f",&n2);
media=(n1+n2*2)/3;
printf("\nmedia:%.2f",media);
if(media>=6)
printf(" voce esta aprovado ");
else
printf("\n Seu Burro ");
}
