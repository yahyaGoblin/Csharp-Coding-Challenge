namespace Ans_28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("String Palindrome Check");
            Console.WriteLine("Enter a string to check if it is a palindrome or not");
            string input = Console.ReadLine();
            if (IsPalindrome(input))
            {
                Console.WriteLine("The string is a palindrome");
            }
            else
            {
                Console.WriteLine("The string is not a palindrome");
            }

        }

        public static bool IsPalindrome(string input)
        {
            int i = 0;
            int j = input.Length - 1;
            while (i < j)
            {
                if (input[i] != input[j])
                {
                    return false;
                }
                i++;
                j--;
            }
            return true;
        }
    }
}