namespace Ans_46
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Palindrome Check");
            Console.WriteLine("Enter a String: ");
            string str = Console.ReadLine();
            bool isPalindrome = IsPalindrome(str);
            Console.WriteLine("Is Palindrome: " + isPalindrome);
        }

        private static bool IsPalindrome(string str)
        {
            int i = 0;
            int j = str.Length - 1;
            while (i < j)
            {
                if (str[i] != str[j])
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
