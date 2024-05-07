namespace Ans_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Even or Odd");
            Console.WriteLine("Enter a number");
            int num = Convert.ToInt32(Console.ReadLine());
            
            if (num % 2 == 0)
            {
                Console.WriteLine($"{num} is even.");
            }
            else
            {
                Console.WriteLine($"{num} is odd.");
            }
        }
    }
}