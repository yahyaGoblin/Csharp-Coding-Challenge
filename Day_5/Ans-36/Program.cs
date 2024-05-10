namespace Ans_36
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Remove duplicate elements in a integer array");

            int[] array = { 1, 2, 3, 4, 5, 1, 2, 3, 4, 5 };
            int[] uniqueArray = new int[array.Length];
            int index = 0;

            foreach (int i in array)
            {
                bool isPresent = false;
                foreach (int j in uniqueArray)
                {
                    if (i == j)
                    {
                        isPresent = true;
                        break;
                    }
                }

                if (!isPresent)
                {
                    uniqueArray[index] = i;
                    index++;
                }
            }

            Console.WriteLine("Unique elements in the array are:");
            for (int i = 0; i < index; i++)
            {
                Console.WriteLine(uniqueArray[i]);
            }
        }
    }
}
