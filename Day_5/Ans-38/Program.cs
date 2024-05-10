namespace Ans_38
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Average of an array");

            int[] array = { 5, 6, 3, 4, 2, 1 };
            int sum = 0;

            foreach (int i in array)
            {
                sum += i;
            }

            Console.WriteLine("Average of the array is: " + sum / array.Length);
        }
    }
}
