namespace Ans_18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Leap Year Program");
            Console.WriteLine("Enter the year to check if it is a leap year or not");
            int year = Convert.ToInt32(Console.ReadLine());
            if (year % 4 == 0)
            {
                if (year % 100 == 0)
                {
                    if (year % 400 == 0) Console.WriteLine(year + " is a leap year");
                    else Console.WriteLine(year + " is not a leap year");
                }
                else Console.WriteLine(year + " is a leap year");
            }
            else Console.WriteLine(year + " is not a leap year");

        }
    }
}