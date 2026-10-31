using System;

namespace BasicControlStructure
{
    class CalculoAreaCircunferencia
    {
        /// <summary>
        /// Calcular a área de uma circunferência
        /// </summary>
        /// <param name="raio">Valor do raio da circunferência</param>
        /// <returns>Área da circunfeerência</returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public double CalcularAreaCircunferencia(double raio)
        {
            if(raio <= 0.0)
            {
                throw new ArgumentOutOfRangeException(nameof(raio),"O valor informado deve ser maior que 0.0.");
            }
            return Math.PI * Math.Pow(raio,2);
        }
        /// <summary>
        /// Imprimir a área da circunferência no console
        /// </summary>
        /// <param name="area">Valor da área da circunferência</param>
        public void ImprimirConsole(double area)
        {
            Console.WriteLine($"Área da circunferência do círculo: {area}");
        }
    }
}