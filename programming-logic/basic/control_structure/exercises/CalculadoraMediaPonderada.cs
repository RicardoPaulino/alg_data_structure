using System;
namespace BasicControlStructure
{
    public class CalculadoraMediaPonderada
    {
        const string NotaErrorMessage = "A Nota está fora do range aceitável entre 0 e 10.0";
        const string PesoErrorMessage = "O valor do peso deve ser maior que zero";
        const string SomaPesoErrorMessage = "A soma dos pesos deve ser maior que zero";

        public double CalcularMediaPonderada(double nota1, double nota2, double nota3, double peso1, double peso2, double peso3)
        {
            if (nota1 < 0 || nota1 > 10.0)
                throw new ArgumentOutOfRangeException(nameof(nota1), NotaErrorMessage);

            if (nota2 < 0 || nota2 > 10.0)
                throw new ArgumentOutOfRangeException(nameof(nota2), NotaErrorMessage);

            if (nota3 < 0 || nota3 > 10.0)
                throw new ArgumentOutOfRangeException(nameof(nota3), NotaErrorMessage);

            if (peso1 <= 0)
                throw new ArgumentOutOfRangeException(nameof(peso1), PesoErrorMessage);
            if (peso2 <= 0)
                throw new ArgumentOutOfRangeException(nameof(peso2), PesoErrorMessage);
            if (peso3 <= 0)
                throw new ArgumentOutOfRangeException(nameof(peso3), PesoErrorMessage);

            if((peso1 + peso2 + peso3) <= 0)
            throw new ArgumentException(SomaPesoErrorMessage);    

            return  (nota1 * peso1 + nota2 * peso2 + nota3 * peso3) / (peso1 + peso2 + peso3);
        }
    }
}