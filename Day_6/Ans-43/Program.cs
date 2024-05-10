namespace Ans_43
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prime Number Check");
            Console.WriteLine("Enter a Number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            bool isPrime = IsPrime(num);
            Console.WriteLine("Is Prime: " + isPrime);
        }

        private static bool IsPrime(int num)
        {
            if (num <= 1)
            {
                return false;
            }
            for (int i = 2; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
