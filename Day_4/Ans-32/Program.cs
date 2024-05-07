namespace Ans_32
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pascal Triangle");
            Console.WriteLine("Enter the number of rows to print Pascal Triangle");
            int input = Convert.ToInt32(Console.ReadLine());
            PrintPascalTriangle(input);
        }

        public static void PrintPascalTriangle(int input)
        {
            for (int i = 0; i < input; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write($"{Factorial(i) / (Factorial(j) * Factorial(i - j))} ");
                }
                Console.WriteLine();
            }
        }

        public static int Factorial(int input)
        {
            int factorial = 1;
            for (int i = 1; i <= input; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}