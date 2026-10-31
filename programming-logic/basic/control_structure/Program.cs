using System;
using BasicControlStructure;

var trocador = new TrocaValoresAeB();

int valorA = 10;
int valorB = 20;

Console.WriteLine($"Valores originais: A = {valorA}, B = {valorB}");

// Executando o método e desestruturando a tupla retornada diretamente em novas variáveis
var (novoA, novoB) = trocador.TrocarValoresDeAparaB(valorA, valorB);

Console.WriteLine($"Valores trocados: A = {novoA}, B = {novoB}");

// Note que as variáveis originais continuam intactas (Imutabilidade)
Console.WriteLine($"Variáveis originais preservadas: A = {valorA}, B = {valorB}");