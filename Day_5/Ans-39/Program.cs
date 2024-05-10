namespace Ans_39
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Reverse an array");

            int[] array = { 1, 2, 3, 4, 5 };
            int[] reversedArray = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                reversedArray[i] = array[array.Length - 1 - i];
            }

            Console.WriteLine("Reversed array:");
            foreach (int i in reversedArray)
            {
                Console.WriteLine(i);
            }
        }
    }
}
