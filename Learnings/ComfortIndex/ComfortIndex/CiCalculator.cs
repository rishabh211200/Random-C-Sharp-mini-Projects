using System;

namespace CiCalclulator
{
    class WeatherUtilities
    {
        static public float FahrenheitToCelsius(float temperatureFahrenheit)
        {
            return (temperatureFahrenheit - 32) / 1.8f;
        }

        static public float CelsiusToFahrenheit(float temperatureCelsius)
        {
            return temperatureCelsius * 1.8f + 32;
        }

        // The higher the index, the lower the comfort.
        static private float ComfortIndex(float temperatureFahrenheit, float humidityPercent) // private access specifier as ComfortIndex calculator is not called directly so no need.
        {
            // Probably not a very reliable formula:
            return (temperatureFahrenheit + humidityPercent) / 4; // Automatic refactoring removes additional var.
        }

        static public void Report(string location, float temperatureCelsius, float humidity)
        {
            var temperatureFahrenheit = CelsiusToFahrenheit(temperatureCelsius);
            string value = $"Comfort Index for {location}: {ComfortIndex(temperatureFahrenheit, humidity)}";
            Console.WriteLine(value); // Automatic String Interpolation from quick actions and refactoring
            //using refactoring (automatic string interpolation )
        }
    }
}
//Classes and Objects
//Refactoring
//Debugging(needs to learn more)
//Concatination
//Interpolation
//Breakpoints and Conditions