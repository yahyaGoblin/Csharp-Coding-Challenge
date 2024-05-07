namespace Ans_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("String to Upper Case and Lower Case Program");

            Console.WriteLine("Enter a string");
            string input = Console.ReadLine();

            string upperCase = input.ToUpper();
            string lowerCase = input.ToLower();

            Console.WriteLine("Upper Case: " + upperCase);
            Console.WriteLine("Lower Case: " + lowerCase);
        }
    }
}