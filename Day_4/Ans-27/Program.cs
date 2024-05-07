namespace Ans_27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prime Number check");
            
            Console.WriteLine("Enter a number");
            int num = Convert.ToInt32(Console.ReadLine());
            
            bool isPrime = true;
            
            if (num == 0 || num == 1)
            {
                isPrime = false;
            }
            else
            {
                for (int i = 2; i <= num / 2; i++)
                {
                    if (num % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
            }
            
            if (isPrime)
            {
                Console.WriteLine(num + " is a prime number");
            }
            else
            {
                Console.WriteLine(num + " is not a prime number");
            }
        }
    }
}