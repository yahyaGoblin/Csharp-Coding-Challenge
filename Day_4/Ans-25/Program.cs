namespace Ans_25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Multilplication table of Number");
            Console.WriteLine("Enter the number");
            int num = Convert.ToInt32(Console.ReadLine());
            
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(num + " * " + i + " = " + num * i);
            }
        }
    }
}