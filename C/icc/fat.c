#include <stdio.h>
#include <stdlib.h>

void main(){
    int n, fat, i;
    printf("Digite um numero: ");
    scanf("%d", &n);
    fat = 1;
    i = 2;
    while(i <= n){
        fat = fat * i;
        i++;
    }
    printf("O fatorial de %d é %d\n", n, fat);
}