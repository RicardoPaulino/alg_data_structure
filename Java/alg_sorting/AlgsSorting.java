

public class AlgsSorting{

    public static void BubbleSort(int arr[]){
        System.out.println("------------------------------------------------------------");
        System.out.println("BubbleSort");
        System.out.println("------------------------------------------------------------");
        System.out.println("Array original:");
        ImprimirArray(arr);
        System.out.println("Array ordenado usando 2 for alinhados - O(n²):");
        int swap;
        for(int i = 0; i < arr.length - 1; i++){
            for(int j = 0; j < arr.length - i - 1; j++){
                if(arr[j] > arr[j + 1]){
                    swap = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = swap;
                }
            }
        }

        ImprimirArray(arr);

        System.out.println("Array ordenado usando do while - O(n²):");
        int trocou;
        do{
            trocou = 0;
            for(int i = 0; i < arr.length - 1; i++){
                if(arr[i] > arr[i + 1]){
                    swap = arr[i];
                    arr[i] = arr[i + 1];
                    arr[i + 1] = swap;
                    trocou = i;
                }
            }
        }while(trocou != 0);

        ImprimirArray(arr);
        System.out.println("------------------------------------------------------------");

    }
    public static void SelectionSort(int arr[]){

    }
    public static void InsertionSort(int arr[]){

    }

    public static void MergeSort(int arr[]){

    }
    public static void QuickSort(int arr[]){

    }
    public static void HeapSort(int arr[]){

    }
    public static void CountingSort(int arr[]){

    }
    public static void RadixSort(int arr[]){

    }
    public static void ImprimirArray(int arr[]){
        for(int i = 0; i < arr.length; i++){
            System.out.print(arr[i] + " ");
        }
        System.out.println();
    }

    public static void main(String[] args){
        int arr[] = {5, 2, 9, 1, 51, 6, 3, 4, 8, 7, 65, 98 ,0, 12, 11, 10};
        BubbleSort(arr);
        // SelectionSort(arr);
        // InsertionSort(arr);
        // MergeSort(arr);
        // QuickSort(arr);
        // HeapSort(arr);
        // CountingSort(arr);
        // RadixSort(arr);
    }
}