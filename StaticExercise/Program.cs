namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            TempConverter tempConverter = new TempConverter();
            double fahrenheit = 60;
            double celsius = 15.6;

            double toCelsius = tempConverter.FahrenheitToCelsius(fahrenheit);
            double toFahrenheit = tempConverter.CelsiusToFahrenheit(celsius);

            Console.WriteLine($"{fahrenheit} Fahrenheit is {toCelsius} Celsius.");
            Console.WriteLine($"{celsius} Celsius is {toFahrenheit} Fahrenheit.");

        }
    }
}
