namespace Ans_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("simple interest calculator Program");

            Console.WriteLine("Enter the principal amount");
            double principal = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the rate of interest");
            double rate = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the time period in years");
            double time = Convert.ToDouble(Console.ReadLine());

            double simpleInterest = (principal * rate * time) / 100;

            Console.WriteLine("Simple Interest is: " + simpleInterest);
        }
    }
}