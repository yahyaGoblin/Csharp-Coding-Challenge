namespace Ans_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number Swap Program");
            
            Console.WriteLine("Enter the first number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Enter the second number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Before Swapping");
            Console.WriteLine("First Number: " + num1);
            Console.WriteLine("Second Number: " + num2);
            
            num1 = num1 + num2;
            num2 = num1 - num2;
            num1 = num1 - num2;

            Console.WriteLine("After Swapping");
            Console.WriteLine("First Number: " + num1);
            Console.WriteLine("Second Number: " + num2);
        }
    }
}