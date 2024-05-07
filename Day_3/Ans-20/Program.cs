namespace Ans_20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Perfect Square Program");
            Console.WriteLine("Enter the number to check if it is a perfect square or not");
            int number = Convert.ToInt32(Console.ReadLine());
            int sqrt = (int)Math.Sqrt(number);
            
            if (sqrt * sqrt == number) Console.WriteLine(number + " is a perfect square");
            else Console.WriteLine(number + " is not a perfect square");
        
        }
    }
}