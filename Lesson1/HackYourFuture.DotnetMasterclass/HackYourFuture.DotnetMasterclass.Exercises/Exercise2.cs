using System.ComponentModel;

namespace HackYourFuture.DotnetMasterclass.Exercises
{
    public class Exercise2
    {
        // Write a method to convert from user inputted celsius degrees to Fahrenheit

        public static void ConvertCelsiusToFahrenheit()
        {
            Console.WriteLine("Please enter a the temperature in degrees Celsius: ");
            var degreesCelsiusString = Console.ReadLine();

            double tempInCelsius;
            while (!double.TryParse(degreesCelsiusString, out tempInCelsius))
            {
                Console.Write("Invalid temperature. Please enter a valid decimal number: ");
                degreesCelsiusString = Console.ReadLine();
            }

            var tempInFahrenheit = (tempInCelsius * 1.8) + 32;

            Console.WriteLine($"The temperature in Fahrenheit is: {tempInFahrenheit} °F");
            Console.ReadLine();
        }
    }
}