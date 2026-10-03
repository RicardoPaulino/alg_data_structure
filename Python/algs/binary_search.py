def binary_search(arr, target):
    baixo = 0
    alto = len(arr) - 1
    while baixo <= alto:
        meio = (baixo + alto) // 2
        if arr[meio] == target:
            return meio
        elif arr[meio] < target:
            baixo = meio + 1
        else:
            alto = meio - 1
    return -1

if __name__ == "__main__":
    print("Binary Search Algorithm in Python")
    
    # A lista PRECISA estar ordenada para a busca binária funcionar
    numeros = [10, 20, 30, 40, 50, 60, 70, 80, 90]
    alvo = 60

    resultado = binary_search(numeros, alvo)

    if resultado != -1:
        print(f"Elemento {alvo} encontrado no índice {resultado}.")
    else:
        print(f"Elemento {alvo} não encontrado na lista.")