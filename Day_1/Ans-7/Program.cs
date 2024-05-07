namespace Ans_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SIMPLE CALCULATOR");
            Console.WriteLine("...................");
            Console.WriteLine("Enter the first number");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the operation you want to perform");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            int operation = Convert.ToInt32(Console.ReadLine());

            switch (operation)
            {
                case 1:
                    Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
                    break;
                case 2:
                    Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
                    break;
                case 3:
                    Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
                    break;
                case 4:
                    Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
                    break;
                default:
                    Console.WriteLine("Invalid operation");
                    break;
            }
        }
    }
}