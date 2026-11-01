using System;
using System.Collections.Generic;

namespace TabelaHashManual
{
    class Program
    {
        // 1. Nossa Função Hash personalizada para espalhar as chaves nas gavetas
        static int FuncaoHash(string chave, int totalGavetas)
        {
            int somaCodigosLetras = 0;

            // Soma o valor numérico (ASCII/Unicode) de cada caractere da chave
            foreach (char letra in chave)
            {
                somaCodigosLetras += letra;
            }

            // O operador % (resto da divisão) garante que o resultado fique entre 0 e (totalGavetas - 1)
            return somaCodigosLetras % totalGavetas;
        }

        static void Main(string[] args)
        {
            int numeroDeGavetas = 10;
            string minhaChave = "Maçã";

            int gavetaDestino = FuncaoHash(minhaChave, numeroDeGavetas);

            Console.WriteLine($"A chave '{minhaChave}' deve ser guardada na gaveta: {gavetaDestino}");
        }
    }
}