namespace BasicControlStructure
{
    class MediaAritmetica
    {
       public static double CalcMediaAritmetica(double[] numeros)
        {
            double soma = 0;
            for (int i = 0; i < numeros.Length; i++)
            {
                soma += numeros[i];
            }
            return soma / numeros.Length;
        }
    }
}