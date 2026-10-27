using System;

Console.WriteLine("qual o numero de elementos do vetor?");
int itensLength = int.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);
double[] itens = new double[itensLength];
for (int i = 0; i < itensLength; i++)
{
    Console.WriteLine($"Digite o {i + 1}º elemento do vetor:");
    itens[i] = double.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);
}
double media = BasicControlStructure.MediaAritmetica.CalcMediaAritmetica(itens);
Console.WriteLine($"A média aritmética dos elementos do vetor é: {media.ToString("F2")}");