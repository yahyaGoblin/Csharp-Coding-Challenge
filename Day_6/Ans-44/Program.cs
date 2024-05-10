namespace Ans_44
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Temperature Conversion");
            Console.WriteLine("Enter Temperature in Celsius: ");
            double celsius = Convert.ToDouble(Console.ReadLine());
            double fahrenheit = CelsiusToFahrenheit(celsius);
            Console.WriteLine("Temperature in Fahrenheit: " + fahrenheit);

        }

        private static double CelsiusToFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }
    }
}
