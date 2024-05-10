namespace Ans_41
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Two Numbers: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Sum of Two Numbers: " + Sum(num1, num2));
        }

        public static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}
