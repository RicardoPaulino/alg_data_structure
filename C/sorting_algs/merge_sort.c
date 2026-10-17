#include <stdio.h>
#include <stdlib.h>

void merge(int *arr, int idxInicio, int idxMeio, int idxFim){
   
    int i = idxInicio;
    int j = idxMeio + 1;
    int idxArrTemp = 0;
    int *arrTemp = (int *)malloc((idxFim - idxInicio + 1) * sizeof(int));
    
    while(i <= idxMeio && j <= idxFim) {
        if(arr[i] <= arr[j]){
            arrTemp[idxArrTemp] = arr[i];
            i++;
        } else {
            arrTemp[idxArrTemp] = arr[j];
            j++;
        }
        idxArrTemp++;
    }
    // Copy remaining elements from the left subarray, if any
    if(i <= idxMeio){
        while(i <= idxMeio){
            arrTemp[idxArrTemp] = arr[i];
            i++;
            idxArrTemp++;
        }
    } else {
        while(j <= idxFim){
            arrTemp[idxArrTemp] = arr[j];
            j++;
            idxArrTemp++;
        }
    }
    // Copy the sorted elements back to the original array
    for(int k = 0; k < idxArrTemp; k++){
        arr[idxInicio + k] = arrTemp[k];
    }

    // Free the temporary array
    free(arrTemp);
}

void mergeSort(int *arr, int idxInicio, int idxFim){

    if(idxInicio < idxFim){
        int idxMeio = (idxInicio + idxFim) / 2;
        mergeSort(arr, idxInicio, idxMeio);
        mergeSort(arr, idxMeio + 1, idxFim);
        merge(arr, idxInicio, idxMeio, idxFim);
    }
}

int main() {
    int arr[] = {38, 27, 43, 3, 9, 82, 10};
    int tamanho = sizeof(arr) / sizeof(arr[0]);

    printf("Array desordenado:\n");
    for (int i = 0; i < tamanho; i++) {
        printf("%d ", arr[i]);
    }
    printf("\n");

    mergeSort(arr, 0, tamanho - 1);

    printf("Array ordenado:\n");
    for (int i = 0; i < tamanho; i++) {
        printf("%d ", arr[i]);
    }
    printf("\n");

    return 0;
}