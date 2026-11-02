namespace SortingAlgorithms
{
    public class SortingAlgs
    {
        public int[] BubbleSort(int[] arr)
        {
            if(arr == null) 
                throw new ArgumentNullException(nameof(arr),"O array deve ser informado");
            if(arr.Length < 2) 
                throw new ArgumentException(nameof(arr), "O array deve possuir pelo menos 2 elementos");

            int swapped = 0;
            do
            {                
                int temporary;
                swapped = 0;
                for(int i = 0; i < arr.Length - 1; i++)
                {
                    if(arr[i] > arr[i+1])
                    {
                        temporary = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = temporary;
                        swapped = i + 1;
                    }
                    
                }                
            }while(swapped != 0);

            return arr;
        }
        public void PrintArray(int[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                System.Console.Write(arr[i] + " ");
            }
            System.Console.WriteLine();
        }
    }
}