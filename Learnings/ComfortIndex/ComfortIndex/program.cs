using System;
using CiCalclulator;

namespace ComfortIndex
{
    class CheckComfort
    {
        static void Main(string[] args)
        {
            // The higher the index, the lower the comfort.
            Console.WriteLine("Where should we go in May?");
            WeatherUtilities.Report("Delhi", WeatherUtilities.FahrenheitToCelsius(97), 18); //Calling Methods from WeatherUtilities class 
            WeatherUtilities.Report("Mumbai", WeatherUtilities.FahrenheitToCelsius(85), 70); //Calling Methods from WeatherUtilities class because temperature is needed in celsius
            WeatherUtilities.Report("Singapore", 29, 81); //as per input requiredd
        }
    }
}
