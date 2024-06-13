using System;
namespace StaticExercise
{
	public class TempConverter
	{
		public double FahrenheitToCelsius(double fahrenheit)
		{
			return (fahrenheit - 32) * 5.0 / 9.0;
		}
		public double CelsiusToFahrenheit(double celsius)
		{
			return (celsius * 9.0 / 5.0) + 32;
		}

    }
}

