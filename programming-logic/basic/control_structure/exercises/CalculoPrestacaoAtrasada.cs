namespace BasicControlStructure
{
    public class CalculoPrestacaoAtrasada
    {
        const string ErrorValorOriginalOutOfRange = "O valor original deve ser informado e estar acima de 0.0";
        const string ErrorTaxaJuroOutOfRange = "O valor da taxa de juros deve ser informada e estar acima de 0%";
        const string ErrorTempoEmAtrasoOutOfRange = "O tempo de atraso deve ser informado e estar acima de 0";
        
        public decimal CalcularPrestacaoAtrasada(decimal valorOriginal, double taxaJuro, int tempoEmAtraso)
        {
            if(valorOriginal <= 0)
            throw new ArgumentOutOfRangeException(nameof(valorOriginal),ErrorValorOriginalOutOfRange);
            if(taxaJuro <= 0)
            throw new ArgumentOutOfRangeException(nameof(taxaJuro),ErrorTaxaJuroOutOfRange);
            if(tempoEmAtraso <= 0)
            throw new ArgumentOutOfRangeException(nameof(tempoEmAtraso),ErrorTempoEmAtrasoOutOfRange);
            return valorOriginal + (valorOriginal*((decimal)taxaJuro / 100)*tempoEmAtraso);
        }
    }
}