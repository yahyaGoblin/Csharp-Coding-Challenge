namespace Ans_48
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Random Number Generator in a Range");
            Console.WriteLine("Enter Minimum Value: ");
            int min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Maximum Value: ");
            int max = Convert.ToInt32(Console.ReadLine());
            int random = GenerateRandomNumber(min, max);
            Console.WriteLine("Random Number: " + random);
        }

        private static int GenerateRandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max + 1);
        }
    }
}
