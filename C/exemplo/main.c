#include <stdio.h>

int search_key(int arr[] , int tam, int key){
    for(int i = 0; i < tam; i++){
        if(arr[i] == key){
            return i;
        }
    }
    return -1;
}
// maior elemento do array
int max_element(int arr[], int tam){
    int maior = arr[0];
    for(int i = 1; i < tam; i++){
        if(arr[i] > maior){
            maior = arr[i];
        }
    }
    return maior;
}
// menor elemento do array
int min_element(int arr[], int tam){
    int menor = arr[0];
    for(int i = 1; i < tam; i++){
        if(arr[i] < menor){
            menor = arr[i];
        }
    }
    return menor;
}

int main(){
    int arr[] = {1, 2, 3, 4, 5};
    int size = sizeof(arr) / sizeof(arr[0]);
    int key = 3;
    int min = min_element(arr, size);
    int max = max_element(arr, size);
    int result = search_key(arr, size, key);
    if(result != -1){
        printf("Element found at index %d\n", result);
    } else {
        printf("Element not found\n");
    }
    printf("Minimum element: %d\n", min);
    printf("Maximum element: %d\n", max);
    return 0;
}