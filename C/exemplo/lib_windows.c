#include <stdio.h>
#include <unistd.h> // Para a função sleep (pausar o programa)

// Códigos ANSI para colorir o texto no terminal do Linux
#define ANSI_COLOR_GREEN   "\x1b[32m"
#define ANSI_COLOR_RED     "\x1b[31m"
#define ANSI_COLOR_RESET   "\x1b[0m"

int main() {
    // 1. Muda a cor para verde
    printf(ANSI_COLOR_GREEN "=== TESTE DE CORES NO LINUX ===\n");
    printf("Este texto esta em verde usando codigos ANSI!\n" ANSI_COLOR_RESET);

    // 2. Pausa a execução por 1 segundo (equivalente ao Sleep do Windows)
    printf("Aguardando 1 segundo...\n");
    sleep(1);

    // 3. Muda a cor para vermelho
    printf(ANSI_COLOR_RED "\nAviso: A biblioteca windows.h nao existe no Linux!\n" ANSI_COLOR_RESET);

    return 0;
}