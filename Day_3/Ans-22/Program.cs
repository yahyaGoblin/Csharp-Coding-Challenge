namespace Ans_22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Palindrome Program");
            Console.WriteLine("Enter the number to check if it is a palindrome or not");
            int number = Convert.ToInt32(Console.ReadLine());
            int temp = number;
            int reverse = 0;
            while (number != 0)
            {
                reverse = reverse * 10 + number % 10;
                number /= 10;
            }
            if (temp == reverse) Console.WriteLine(temp + " is a palindrome");
            else Console.WriteLine(temp + " is not a palindrome");
        }
    }
}