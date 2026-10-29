
namespace BasicInit
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = { 5, 2, 36, 94, 5, 1, 7, 3, 8, 4 };
            bubbleSort(arr);
            Console.WriteLine("Sorted array: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }

        private static void bubbleSort(int[] arr)
        {
            int tam = arr.Length;
            int swaps;
            do
            {
                swaps = 0;
                for (int i = 0; i < tam - 1; i++)
                {
                    if(arr[i] > arr[i + 1])
                    {
                        int temp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = temp;
                        swaps = i;
                    }                    
                }
            } while (swaps > 0);
        }
    }
}
