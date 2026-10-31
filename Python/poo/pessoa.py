class Pessoa:
    def __init__(self, nome:str, profissao:str):
        self.nome = nome
        self.profissao = profissao
        
    def apresentar(self):
        print(f"Olá, meu nome é {self.nome} e trabalho como {self.profissao}.")
        
        
if __name__ == "__main__":
    p1 = Pessoa("Ricardo","Software Engeneer")
    
    p1.apresentar()   