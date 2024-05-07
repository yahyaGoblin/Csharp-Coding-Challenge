namespace Ans_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sum, Average, Product of 3 Numbers Program");

            Console.WriteLine("Enter the first number");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the third number");
            int num3 = Convert.ToInt32(Console.ReadLine());

            int sum = num1 + num2 + num3;
            double average = sum / 3.0;
            int product = num1 * num2 * num3;

            Console.WriteLine("Sum of the numbers is: " + sum);
            Console.WriteLine("Average of the numbers is: " + average);
            Console.WriteLine("Product of the numbers is: " + product);
        }
    }
}