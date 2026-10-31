namespace BasicControlStructure
{
    public class CalculaEquacaoSegundoGrau
    {
        public (double x1, double x2) CalcularBaskara(double a, double b, double c)
        {
            if (a == 0) throw new ArgumentOutOfRangeException(nameof(a), "Para equação do 2° grau o coeficiente a deve ser diferente de 0.0");

            double delta = Math.Pow(b, 2) - 4 * a * c;

            if (delta < 0) throw new Exception("A equação possui delta menor que zero.");

            double raizDelta = Math.Sqrt(delta);
           
            double x1 = (-b + raizDelta) / (2 * a);
            double x2 = (-b - raizDelta) / (2 * a);
            return (x1, x2);
        }
    }
}