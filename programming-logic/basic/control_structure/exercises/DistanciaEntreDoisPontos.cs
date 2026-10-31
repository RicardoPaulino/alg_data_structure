namespace BasicControlStructure
{
    public class DistanciaEntreDoisPontos
    {
        public double CalcularDistancia(double x1, double x2, double y1, double y2)
        {
            double diferencaEntreX1X2  = x2 - x1;
            double diferencaoEntreY1eY2  = y2 - y1;

            double potenciaValoresX = Math.Pow(diferencaEntreX1X2,2);
            double potenciaValoresY = Math.Pow(diferencaoEntreY1eY2,2);

            return Math.Sqrt(potenciaValoresX + potenciaValoresY); 
        }

    }
}