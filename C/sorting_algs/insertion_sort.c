#include <stdio.h>
#include <stdlib.h>
void insertion_sort(int arr[], int n) {
    int i, j, atual;
    for (i = 1; i < n; i++) {
        atual = arr[i];
        for(j = i; (j > 0) && (atual < arr[j - 1]); j--) {
            arr[j] = arr[j - 1];
        }
        arr[j] = atual;
    }
}

int main() {
    int arr[] = {12, 11, 13, 5, 6};
    int n = sizeof(arr) / sizeof(arr[0]);
    insertion_sort(arr, n);
    printf("Sorted array: \n");
    for (int i = 0; i < n; i++)
        printf("%d ", arr[i]);
    printf("\n");
    return 0;
}