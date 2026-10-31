using System;
namespace BasicControlStructure
{
    public class ConversorMoeda
    {
        const string CotacaoErrorOutOfRange = "A cotação deve ser maior que 0.0.";
        const string QtdDolarErrorOutOfRange = "A quantidade de dolares deve ser maior que 0.0.";
        public decimal ConverterDolarToReal(decimal cotacaodolar, decimal qtdDolar)
        {
            if (cotacaodolar <= 0)
                throw new ArgumentOutOfRangeException(nameof(cotacaodolar), CotacaoErrorOutOfRange);
            if (qtdDolar <= 0)
                throw new ArgumentOutOfRangeException(nameof(qtdDolar), QtdDolarErrorOutOfRange);

            return qtdDolar * cotacaodolar;
        }

        public void ImprimirCotacao(decimal qtdDolar, decimal valorEmReais)
        {
            Console.WriteLine($"{qtdDolar} dolares = {valorEmReais} reais");
        }
    }
}