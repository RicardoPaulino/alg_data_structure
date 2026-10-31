def imprimi_lista():
    numeros = [1,3,6,5,9,33,14,17]
    for i in numeros:
        print(f"valor {i}")

def imprimi_dict():
    pessoa = [
        {
        "nome": "Ricardo",
        "profissao": "dev"
        },
        {
            "nome": "Marcela",
            "profissao": "RH"
        }
    ]
    
    for person in pessoa:
        print("Nome: ", person["nome"])
        print("Profissao: ", person["profissao"])
        
if __name__=="__main__":
    imprimi_lista()
    imprimi_dict()        