#include <stdio.h>
#include <stdlib.h> 

void selection_sort(int arr[], int n)
{
    int i, j, min_idx, aux;
    for (i = 0; i < n - 1; i++)
    {
        min_idx = i;
        for (j = i + 1; j < n; j++)
        {
            if (arr[j] < arr[min_idx])
            {
                min_idx = j;
            }
        }
        aux = arr[min_idx];
        arr[min_idx] = arr[i];
        arr[i] = aux;
    }
}   

int main()
{
    int arr[] = {15, 2, 9, 1, 5, 6, 3, 8, 4, 7, 10, 12, 13, 0,154, 88, 99, 112, 11, 14};
    int n = sizeof(arr) / sizeof(arr[0]);
    selection_sort(arr, n);
    for (int i = 0; i < n; i++)
    {
        printf("%d ", arr[i]);
    }
    printf("\n");
    return 0;
}