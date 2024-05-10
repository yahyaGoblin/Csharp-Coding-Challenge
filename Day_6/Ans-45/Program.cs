namespace Ans_45
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Occurrences of Specific Character Check");
            Console.WriteLine("Enter a String: ");

            string str = Console.ReadLine();
            Console.WriteLine("Enter a Character: ");
            char ch = Convert.ToChar(Console.ReadLine());

            int occurrences = CountOccurrences(str, ch);
            Console.WriteLine("Occurrences of " + ch + ": " + occurrences);
        }

        private static int CountOccurrences(string str, char ch)
        {
            return str.Count(c => c == ch);
        }
    }
}
