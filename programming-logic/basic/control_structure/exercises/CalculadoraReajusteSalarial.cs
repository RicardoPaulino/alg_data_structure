using System;
namespace BasicControlStructure
{
    public class CalculadoraReajusteSalarial
    {
        /// <summary>
        /// Calcula o novo salário com base em um percentual de reajuste.
        /// Complexidade de Tempo: O(1)
        /// Complexidade de Espaço: O(1)
        /// </summary>
        public decimal CalcularReajusteSalarial(decimal salarioAtual, double percentualReajuste)
        {
            if (salarioAtual <= 0)
                throw new ArgumentOutOfRangeException(nameof(salarioAtual), "O salário informado deve ser maior que zero");
            if (percentualReajuste <= 0.0)
                throw new ArgumentOutOfRangeException(nameof(percentualReajuste), "O percentual de reajuste deve ser maior que 0.0%");
            return salarioAtual + (salarioAtual * ((decimal)percentualReajuste / 100));
        }
    }
}