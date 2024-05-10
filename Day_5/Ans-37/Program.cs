﻿namespace Ans_37
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Array in ascending and descending order");

            int[] array = { 5, 6, 3, 4, 2, 1 };
            int temp;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }

            Console.WriteLine("Array in ascending order:");
            foreach (int i in array)
            {
                Console.WriteLine(i);
            }

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] < array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }

            Console.WriteLine("Array in descending order:");
            foreach (int i in array)
            {
                Console.WriteLine(i);
            }
        }
    }
}
