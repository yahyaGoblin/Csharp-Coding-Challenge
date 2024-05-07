namespace Ans_29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Factorial of Given Number using Recursion");
            Console.WriteLine("Enter a number to find its factorial");
            int input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Factorial of {input} is {Factorial(input)}");
        }

        public static int Factorial(int input)
        {
            if (input == 0)
            {
                return 1;
            }
            return input * Factorial(input - 1);
        }
        
    }
}