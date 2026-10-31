def imprimir(message: str):
    if(message != ""):
        print(message)

if __name__ == "__main__":
    limite = int(input("Digite o valor do limite: "))
    
    if limite >= 0:
        for i in range(limite):
            imprimir(f"Número da vez: {i + 1}")
    else:
        imprimir("Por favor, digite um número maior ou igual a zero.")
