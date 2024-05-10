namespace Ans_35
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("element checker in a integer array");

            int[] array = { 1, 2, 3, 4, 5 };
            int element = 3;
            bool isPresent = false;

            foreach (int i in array)
            {
                if (i == element)
                {
                    isPresent = true;
                    break;
                }
            }

            if (isPresent)
            {
                Console.WriteLine("Element " + element + " is present in the array");
            }
            else
            {
                Console.WriteLine("Element " + element + " is not present in the array");
            }
        }
    }
}
