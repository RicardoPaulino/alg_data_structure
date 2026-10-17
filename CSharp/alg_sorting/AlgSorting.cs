public class AlgSorting
{
    public static void BubbleSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }
    public static void SelectionSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < n; j++)
            {
                if (arr[j] < arr[minIndex])
                {
                    minIndex = j;
                }
            }
            int temp = arr[minIndex];
            arr[minIndex] = arr[i];
            arr[i] = temp;
        }
    }
    public static void InsertionSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 1; i < n; ++i)
        {
            int key = arr[i];
            int j = i - 1;
            while (j >= 0 && arr[j] > key)
            {
                arr[j + 1] = arr[j];
                j = j - 1;
            }
            arr[j + 1] = key;
        }
    }

    public static void InsertionSort2(int[] arr)
    {
        System.Console.WriteLine("Array original:");
        PrintArray(arr);
        int i, j, atual, n = arr.Length;
        for (i = 1; i < n; i++)
        {
            atual = arr[i];
            for(j = i; (j > 0) && (atual < arr[j - 1]); j--)
            {
                arr[j] = arr[j - 1];
            }
            arr[j] = atual;
        }
        System.Console.WriteLine("Array ordenado com InsertionSort2:");
        PrintArray(arr);
    }

    public static void MergeSort(int[] arr, int left, int right)
    {
        if (left < right)
        {
            int mid = left + (right - left) / 2;
            MergeSort(arr, left, mid);
            MergeSort(arr, mid + 1, right);
            Merge(arr, left, mid, right);
        }
    }

    public static void Merge(int[] arr, int left, int mid, int right)
    {
        Console.WriteLine("Array original:");
        PrintArray(arr);
        int[] temp = new int[right - left + 1];
        int i = left, j = mid + 1, k = 0;
        while (i <= mid && j <= right)
        {
            if (arr[i] <= arr[j])
            {
                temp[k++] = arr[i++];   
            }
            else
            {
                temp[k++] = arr[j++];   
            }
        }
        if(i <= mid)
        {
            while (i <= mid)
            {
                temp[k++] = arr[i++];
            }
        }
        else
        {
            while (j <= right)
            {
                temp[k++] = arr[j++];
            }
        }

        for (int m = 0; m < k; m++)
        {
            arr[left + m] = temp[m];
        }
        Console.WriteLine("Array ordenado com MergeSort:");
        PrintArray(arr);
    }

    public static void PrintArray(int[] arr)
    {
        foreach (int item in arr)
        {
            System.Console.Write(item + " ");
        }
        System.Console.WriteLine();
    }

    public static int[] GenerateRandomArray(int size = 10, int minValue = 0, int maxValue = 100)
    {
        Random rand = new Random();
        int[] arr = new int[size];
        for (int i = 0; i < size; i++)
        {
            arr[i] = rand.Next(minValue, maxValue);
        }
        return arr;
    }

    public static void Main(string[] args)
    {
        // BubbleSort(arr);
        // SelectionSort(arr);
        // InsertionSort(arr);
        //InsertionSort2(GenerateRandomArray());
        MergeSort(GenerateRandomArray(), 0, arr.Length - 1);
    }
}