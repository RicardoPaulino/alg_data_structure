using SortingAlgorithms;

public class Program
{
    public static void Main(string[] args)
    {
        int[] arr = {15,2,69,45,36,1,78,9,58,0};
        SortingAlgs sortingAlgs = new SortingAlgs();
        sortingAlgs.BubbleSort(arr);
        sortingAlgs.PrintArray(arr);
    }
}
