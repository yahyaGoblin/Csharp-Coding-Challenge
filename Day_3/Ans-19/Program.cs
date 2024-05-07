namespace Ans_19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Factorial Program");
            Console.WriteLine("Enter the number to find the factorial");
            int number = Convert.ToInt32(Console.ReadLine());
            int factorial = 1;
            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
                Console.Write("Factorial of " + i + " is " + factorial);
            }
        }
    }
}