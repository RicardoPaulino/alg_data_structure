using System;

namespace BasicControlStructure
{
    public class ConsumoAutomotivo
    {
        /// <summary>
        /// Calcula o consumo médio de um automóvel com base na distância percorrida e no combustível gasto.
        /// Complexidade de Tempo: O(1)
        /// Complexidade de Espaço: O(1)
        /// </summary>
        /// <param name="distanciaTotal">Distância total em quilômetros (deve ser estritamente positiva).</param>
        /// <param name="combustivelTotal">Total de combustível gasto em litros (deve ser estritamente positivo).</param>
        /// <returns>O consumo médio em Km/L.</returns>
        public double CalcularConsumoMedio(double distanciaTotal, double combustivelTotal)
        {
            // 1. Defesa contra entradas inválidas (Fail Fast)
            // Em entrevistas, validar os limites do domínio do problema demonstra maturidade.
            if (distanciaTotal <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(distanciaTotal), "A distância percorrida deve ser maior que zero.");
            }

            if (combustivelTotal <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(combustivelTotal), "O combustível gasto deve ser maior que zero.");
            }

            // 2. Proteção contra Overflow ou valores absurdos de negócio (Opcional, mas sênior)
            if (double.IsInfinity(distanciaTotal) || double.IsInfinity(combustivelTotal))
            {
                throw new ArgumentException("Os valores fornecidos excedem os limites suportados.");
            }

            // 3. Execução da lógica com precisão double (padrão IEEE 754 para cálculos científicos/físicos)
            return distanciaTotal / combustivelTotal;
        }
    }
}