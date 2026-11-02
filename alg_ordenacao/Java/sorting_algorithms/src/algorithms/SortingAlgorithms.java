package algorithms;

public class SortingAlgorithms {

    public int[] BubbleSort(int[] arr){
        if(arr == null){
            throw new IllegalArgumentException("O array deve ser informado.");
        }
        if(arr.length < 2){
            throw new IllegalArgumentException("O array deve possuir pelo menos 2 elementos.");
        }
        int swapped = 0;
        do{
            swapped = 0;
            for(int i = 0; i < arr.length -1; i++){                
                if(arr[i] > arr[i + 1]){
                    int temporary = arr[i];
                    arr[i] = arr[i + 1];
                    arr[i + 1] = temporary;
                    swapped = i + 1;
                }
            }
        }while(swapped != 0);
        
        return arr ;
    }
}
