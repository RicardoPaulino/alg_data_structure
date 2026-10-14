#include <stdio.h>
#include <stdlib.h>
#include <stdbool.h>

void bubble_sort(int arr[], int n)
{
    int i, aux;
    bool trocou;
    do{
        trocou = false;
        for (i = 0; i < n - i - 1; i++)
        {
            if (arr[i] > arr[i + 1])
            {
                aux = arr[i];
                arr[i] = arr[i + 1];
                arr[i + 1] = aux;
                trocou = true;
            }
        }
    }while(trocou);
}

int main()
{
    int arr[] = {15, 2, 9, 1, 5, 6, 3, 8, 4, 7, 10, 12, 13, 0,154, 88, 99, 112, 11, 14};
    int n = sizeof(arr) / sizeof(arr[0]);
    bubble_sort(arr, n);
    for (int i = 0; i < n; i++)
    {
        printf("%d ", arr[i]);
    }
    printf("\n");
    return 0;
}