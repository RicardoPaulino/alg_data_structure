#include <stdio.h>
#include <stdlib.h>
#include <math.h>

float calcular_delta(float a, float b, float c){
    return (b*b) - (4*a*c);
}

float calcular_raiz1(float a, float b, float delta){
    return (-b + sqrt(delta)) / (2*a);
}

float calcular_raiz2(float a, float b, float delta){
    return (-b - sqrt(delta)) / (2*a);
}

void main(){
    float a, b, c, delta, raiz1, raiz2;
    printf("Digite os coeficientes a, b e c: ");
    scanf("%f %f %f", &a, &b, &c);
    delta = calcular_delta(a, b, c);
    raiz1 = calcular_raiz1(a, b, delta);
    raiz2 = calcular_raiz2(a, b, delta);
    printf("As raizes sao: %.2f e %.2f\n", raiz1, raiz2);
}