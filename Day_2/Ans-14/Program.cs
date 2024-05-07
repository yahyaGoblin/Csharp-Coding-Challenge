namespace Ans_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("No of days to years, months and days Program");

            Console.WriteLine("Enter the number of days");
            int days = Convert.ToInt32(Console.ReadLine());

            int years = days / 365;
            int months = (days % 365) / 30;
            int remainingDays = (days % 365) % 30;

            Console.WriteLine("Years: " + years);
            Console.WriteLine("Months: " + months);
            Console.WriteLine("Days: " + remainingDays);
            
        }
    }
}