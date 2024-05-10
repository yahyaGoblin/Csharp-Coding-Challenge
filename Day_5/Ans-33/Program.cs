namespace Ans_33
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sum of elements in a integer array");
            
            int[] array = { 1, 2, 3, 4, 5 };
            int sum = 0;
            
            foreach (int i in array)
            {
                sum += i;
            }
            
            Console.WriteLine("Sum of elements in the array is: " + sum);

        }
    }
}
