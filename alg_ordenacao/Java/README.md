# 🚀 Algoritmos de Ordenação em Java

Este projeto faz parte de uma trilha prática de estudos de **Estruturas de Dados e Algoritmos (DSA)**, focado em implementação limpa, programação defensiva e análise de complexidade.

---

## 📂 Estrutura do Projeto

```text
seu-projeto/
├── src/
│   ├── Main.java                  # Classe de entrada e testes
│   └── algorithms/
│       └── SortingAlgorithms.java  # Implementação dos algoritmos de ordenação
└── README.md
```

---

## 🛠️ Como Compilar e Executar via Terminal (CLI)

Certifique-se de estar com o terminal aberto na **raiz do projeto** (onde a pasta `src` está localizada).

### 1. Compilação
Como o projeto utiliza pacotes (`package algorithms`), compile todos os arquivos de origem juntos:

```bash
javac src/algorithms/SortingAlgorithms.java src/Main.java
```

### 2. Execução
Execute a classe principal informando a pasta `src` como diretório de classes (*classpath*):

```bash
java -cp src Main
```

---

## 📋 Algoritmos Implementados

- [x] **Bubble Sort** (Otimizado com controle de índice `swapped`, garantindo $O(N)$ no melhor caso e $O(N^2)$ no pior caso).
- [ ] **Selection Sort** *(Em breve)*
- [ ] **Insertion Sort** *(Em breve)*