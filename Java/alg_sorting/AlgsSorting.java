
import java.util.Random;

public class AlgsSorting {

    public static void bubbleSort(int arrOriginal[]) {
        System.out.println("------------------------------------------------------------");
        System.out.println("BubbleSort");
        System.out.println("------------------------------------------------------------");
        System.out.println("Array original:");
        imprimirArray(arrOriginal);

        // 1. Medindo a abordagem com 2 for aninhados
        // Clonamos o array original para garantir que a entrada seja a mesma
        int[] arr1 = arrOriginal.clone();

        long inicio1 = System.nanoTime(); // Marca o tempo inicial

        int swap;
        for (int i = 0; i < arr1.length - 1; i++) {
            for (int j = 0; j < arr1.length - i - 1; j++) {
                if (arr1[j] > arr1[j + 1]) {
                    swap = arr1[j];
                    arr1[j] = arr1[j + 1];
                    arr1[j + 1] = swap;
                }
            }
        }

        long fim1 = System.nanoTime(); // Marca o tempo final
        long duracao1 = fim1 - inicio1; // Calcula a diferença

        System.out.println("Array ordenado usando 2 for aninhados - O(n²):");
        imprimirArray(arr1);
        System.out.println("Tempo de execução: " + duracao1 + " nanossegundos (" + (duracao1 / 1_000_000.0) + " ms)");

        // 2. Medindo a abordagem com do-while
        // Clonamos o array original novamente para uma base justa de comparação
        int[] arr2 = arrOriginal.clone();

        long inicio2 = System.nanoTime(); // Marca o tempo inicial

        int trocou;
        do {
            trocou = 0;
            for (int i = 0; i < arr2.length - 1; i++) {
                if (arr2[i] > arr2[i + 1]) {
                    swap = arr2[i];
                    arr2[i] = arr2[i + 1];
                    arr2[i + 1] = swap;
                    trocou = i;
                }
            }
        } while (trocou != 0);

        long fim2 = System.nanoTime(); // Marca o tempo final
        long duracao2 = fim2 - inicio2; // Calcula a diferença

        System.out.println("Array ordenado usando do while - O(n²):");
        imprimirArray(arr2);
        System.out.println("Tempo de execução: " + duracao2 + " nanossegundos (" + (duracao2 / 1_000_000.0) + " ms)");

        System.out.println("------------------------------------------------------------");
    }

    public static void selectionSort(int arr[]) {
        long inicio = System.nanoTime(); // Marca o tempo inicial
        System.out.println("Selection Sort");
        System.out.println("------------------------------------------------------------");
        System.out.println("Array original:");
        imprimirArray(arr);

        int menor, aux;
        for (int i = 0; i < arr.length - 1; i++) {
            menor = i;
            for (int j = i + 1; j < arr.length; j++) {
                if (arr[j] < arr[menor]) {
                    menor = j;
                }
            }
            if (menor != i) {
                aux = arr[i];
                arr[i] = arr[menor];
                arr[menor] = aux;
            }
        }

        long fim = System.nanoTime(); // Marca o tempo final
        long duracao = fim - inicio; // Calcula a diferença

        System.out.println("Array ordenado:");
        imprimirArray(arr);
        System.out.println("Tempo de execução: " + duracao + " nanossegundos (" + (duracao / 1_000_000.0) + " ms)");
        System.out.println("------------------------------------------------------------");

    }

    public static void insertionSort(int arr[]) {
        long inicio = System.nanoTime(); // Marca o tempo inicial
        System.out.println("Insertion Sort");
        System.out.println("------------------------------------------------------------");
        System.out.println("Array original:");
        imprimirArray(arr);
        System.out.println("Array ordenado:");
        int j, aux;
        for (int i = 1; i < arr.length; i++) {
            aux = arr[i];
            j = i - 1;
            while (j >= 0 && arr[j] > aux) {
                arr[j + 1] = arr[j];
                j--;
            }
            arr[j + 1] = aux;
        }
        long fim = System.nanoTime(); // Marca o tempo final
        long duracao = fim - inicio; // Calcula a diferença
        imprimirArray(arr);
        System.out.println("Tempo de execução: " + duracao + " nanossegundos (" + (duracao / 1_000_000.0) + " ms)");
        System.out.println("------------------------------------------------------------");
    }

    public static void mergeSort(int arr[]) {

    }

    public static void quickSort(int arr[]) {

    }

    public static void heapSort(int arr[]) {

    }

    public static void countingSort(int arr[]) {

    }

    public static void radixSort(int arr[]) {

    }

    public static void imprimirArray(int arr[]) {
        for (int i = 0; i < arr.length; i++) {
            System.out.print(arr[i] + " ");
        }
        System.out.println();
    }

    public static int[] gerarArrayAleatorio() {
        int tamanho = 100;
        int[] arr = new int[tamanho];
        Random random = new Random();

        for (int i = 0; i < tamanho; i++) {
            // Gera números aleatórios entre 0 e 99999 (ajuste se preferir)
            arr[i] = random.nextInt(100000);
        }

        return arr;
    }

    public static void main(String[] args) {
        int[] arr = gerarArrayAleatorio();
        bubbleSort(arr.clone());
        selectionSort(arr.clone());
        insertionSort(arr.clone());
        // mergeSort(arr);
        // quickSort(arr);
        // heapSort(arr);
        // countingSort(arr);
        // radixSort(arr);
    }
}
