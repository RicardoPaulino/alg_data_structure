using System;

namespace BasicControlStructure
{
    public class ConversorTemperatura
    {
        /// <summary>
        /// Converte uma temperatura de Celsius para Fahrenheit.
        /// </summary>
        /// <param name="temperaturaCelsius">c</param>
        /// <returns>A temperatura convertida em Fahrenheit.</returns>
        public double ConverterCelsiusParaFahrenheit(double temperaturaCelsius)
        {     
            if(temperaturaCelsius <= -273.15) 
            throw new ArgumentOutOfRangeException(nameof(temperaturaCelsius), "A temperatura não pode ser inferior ao zero absoluto (-273.15°C).");  
            return temperaturaCelsius * (9.0 / 5.0) + 32;
        }

        /// <summary>
        /// Imprimi o valor da temperatura no console
        /// </summary>
        /// <param name="temperatura">A temperatura em Fahrenheit</param>
        public void ImprimirTemperaturaConsole(double temperatura)
        {            
            Console.WriteLine($"Temperatura em Fahrenheit é {temperatura:F2}°F");
        }
    }
}