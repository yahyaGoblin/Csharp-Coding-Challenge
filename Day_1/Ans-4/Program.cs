namespace Ans_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Temperature Converter");
            Console.WriteLine("Press 1 to convert Fahrenheit to Celsius");
            Console.WriteLine("Press 2 to convert Celsius to Fahrenheit");
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                Console.WriteLine("Enter the temperature in Fahrenheit");
                double fahrenheit = Convert.ToDouble(Console.ReadLine());
                double celsius = (fahrenheit * 9 / 5) + 32;
                Console.WriteLine($"The temperature in Celsius is {celsius}");
            }
            else if (choice == 2)
            {
                Console.WriteLine("Enter the temperature in Celsius");
                double celsius = Convert.ToDouble(Console.ReadLine());
                double fahrenheit = (celsius * 9 / 5) + 32;
                Console.WriteLine($"The temperature in Fahrenheit is {fahrenheit}");
            }
            else
            {
                Console.WriteLine("Invalid choice");
            }

        }
    }
}