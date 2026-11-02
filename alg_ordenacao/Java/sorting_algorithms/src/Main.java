import algorithms.*;

public class Main{
    public static void main(String[] args){
        
        int[] arr = {15,2,69,45,36,1,78,9,58,0};
        SortingAlgorithms sorting = new SortingAlgorithms();
        sorting.BubbleSort(arr);
        printArray(arr);

    }
    private static void printArray(int[] arr){
        for(int i = 0; i < arr.length; i++){
            System.out.print(arr[i] + " ");
        }
        System.out.println();
    }
}