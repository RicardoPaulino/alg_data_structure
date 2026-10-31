
if __name__ == "__main__":
    idade = int(input("Qual a sua idade?\n"))

    if(idade < 18):
        print("Menor de idade\n")
    elif(idade >= 60):
        print("Pessoa Idosa\n");   
    else:
        print("Idade produtiva\n")