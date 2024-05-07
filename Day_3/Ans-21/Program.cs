namespace Ans_21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sum of Digits Program");
            Console.WriteLine("Enter the number to find the sum of digits");
            int number = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            while (number != 0)
            {
                sum += number % 10;
                number /= 10;
            }
            Console.WriteLine("Sum of digits is " + sum);
        }
    }
}