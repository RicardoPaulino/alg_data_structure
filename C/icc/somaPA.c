#include <stdio.h>
#include <stdlib.h>

// complexidade de tempo: O(n) = n
// O(n) = n
int somaPA(int n, int a1, int r){
    int aq = a1;
    int soma = 0, i = 0;
    while (i < n) {
        soma += aq;
        aq += r;
        i++;
    }
    return soma;
}

// complexidade de tempo: O(1) = 1
// O(1) = 1
int somaPA_otimizada(int n, int a1, int r){
    return (n * (2 * a1 + (n - 1) * r)) / 2;
}

void main(){
    int n, a1, r, soma, soma2;
    printf("Digite o numero de termos (n), o primeiro termo (a1) e a razao (r): ");
    scanf("%d %d %d", &n, &a1, &r);

    soma = somaPA(n, a1, r);
    printf("A soma dos %d primeiros termos da PA é: %d\n", n, soma);

    soma2 = somaPA_otimizada(n, a1, r);
    printf("A soma dos %d primeiros termos da PA (otimizada) é: %d\n", n, soma2);
}