namespace Ans_34
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Largest and smallest element in a integer array");

            int[] array = { 1, 2, 3, 4, 5 };
            int largest = array[0];
            int smallest = array[0];

            foreach (int i in array)
            {
                if (i > largest)
                {
                    largest = i;
                }
                if (i < smallest)
                {
                    smallest = i;
                }
            }

            Console.WriteLine("Largest element in the array is: " + largest);
            Console.WriteLine("Smallest element in the array is: " + smallest);
        }
    }
}
