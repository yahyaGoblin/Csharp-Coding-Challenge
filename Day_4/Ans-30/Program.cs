namespace Ans_30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prime Number Within a Range");
            Console.WriteLine("Enter a number to find prime numbers within the range");
            int input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Prime numbers within the range of {input} are:");
            for (int i = 2; i <= input; i++)
            {
                if (IsPrime(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        public static bool IsPrime(int input)
        {
            if (input == 2)
            {
                return true;
            }
            if (input < 2 || input % 2 == 0)
            {
                return false;
            }
            for (int i = 3; i <= Math.Sqrt(input); i += 2)
            {
                if (input % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}