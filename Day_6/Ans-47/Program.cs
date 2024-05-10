namespace Ans_47
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Factorial Calculation");
            Console.WriteLine("Enter a Number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            long factorial = CalculateFactorial(num);
            Console.WriteLine("Factorial of " + num + ": " + factorial);
        }

        private static long CalculateFactorial(int num)
        {
            if (num == 0)
            {
                return 1;
            }
            return num * CalculateFactorial(num - 1);
        }
    }
}
