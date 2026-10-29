/**
 * Exercício - Cálculo da quantidade de latas de tinta e custo para pintar um cilindro.
 * 
 * @version 1.0
 * 
 * Construa um algoritmo que calcule a quantidade de latas de tinta e o custo 
 * total para pintar um tanque cilíndrico de combustível, em que são fornecidos 
 * a altura e o raio desse cilindro.
 * 
 * Sabendo que:
 * - A lata de tinta custa R$ 50,00;
 * - Cada lata contém 5 litros;
 * - Cada litro de tinta pinta 3 metros quadrados.
 * 
 * Dados de entrada: altura (h) e raio (r).
 * Dados de saída: quantidade de latas de tinta e custo total.
 * 
 * Fórmulas utilizadas na resolução do exercício:
 * - Área total do cilindro: A = 2 * pi * r * (h + r)
 * - Litros necessários: L = A / 3
 * - Quantidade de latas: Latas = L / 5 (arredondado para cima)
 * - Custo total: Custo = Latas * 50
 */ 
using System;
namespace BasicControlStructure
{
    class CalcQuantTintas
    {
        private const decimal ValorPorLata = 50m;
        private const double LitrosPorLata = 5.0;
        private const double RendimentoMetroQuadradoPorLitro = 3.0;

        public void CalcularOrcamentoPintura(double altura, double raio)
        {
            if (altura <= 0 || raio <= 0)
            {
                throw new ArgumentException("A altura e o raio devem ser valores maiores que zero.");
            }

            double areaCilindro = CalculoAreaCilindro(altura, raio);
            double litrosTinta = CalculoLitrosTinta(areaCilindro);
            int qtdLatas = CalculaQuantidadeLatas(litrosTinta);
            decimal custoTotal = CustoTotal(qtdLatas);

            Console.WriteLine($"Quantidade de tintas: {qtdLatas}");
            Console.WriteLine($"Custo total: R$ {custoTotal:F2}");
        }
        public decimal CustoTotal(int quantidadeLatas)
        {            
            return ValorPorLata * quantidadeLatas;
        }

        public double CalculoAreaCilindro(double altura, double raio)
        {
            return 2 * Math.PI * raio * (altura + raio);
        }
        public double CalculoLitrosTinta(double area)
        {
            return area / RendimentoMetroQuadradoPorLitro;
        }
        public int CalculaQuantidadeLatas(double litros)
        {
            return (int)Math.Ceiling(litros / LitrosPorLata);
        }
    }
}