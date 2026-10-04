#include <stdio.h>
#include <stdlib.h>
#include <stdbool.h>

void bubble_sort(int arr[], int n)
{
    int arr_size = n-1;
    int aux, next;
    do
    {        
        next = 0;
        for (int i = 0; i < arr_size; i++)
        {
            if(arr[i] > arr[i + 1]){
                aux = arr[i];
                arr[i] = arr[i + 1];
                arr[i + 1] = aux;
                next = i;
            }           
        }
        arr_size--;
    } while (next != 0);
}

void bubble_sort2(int *arr, int n){
        int tam = n - 1;
        int aux, next;
        bool trocou;
        do{
            trocou = false;
            for (int i = 0; i < tam; i++)
            {
                if(arr[i] > arr[i + 1]){
                    aux = arr[i];
                    arr[i] = arr[i + 1];
                    arr[i + 1] = aux;
                    trocou = true;
                }           
            }
            tam--;
        }while (trocou);
}

int main()
{
    int arr[] = {15, 2, 9, 1, 5, 6, 3, 8, 4, 7, 10, 12, 13, 0,154, 88, 99, 112, 11, 14};
    int n = sizeof(arr) / sizeof(arr[0]);
    bubble_sort2(arr, n);
    for (int i = 0; i < n; i++)
    {
        printf("%d ", arr[i]);
    }
    printf("\n");
    return 0;
}