using System;

namespace bubble_sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] unsortedList = { 4, 2, 7, 1, 5, 3, 9, 6 };

            int temp;

            Console.WriteLine("Before Bubble Sort");

            for (int index = 0; index < unsortedList.Length; index++)
            {
                Console.Write(unsortedList[index] + " ");
            }

            for (int i = 0; i < unsortedList.Length - 1; i++)
            {
                for (int j = 0; j < unsortedList.Length - (i + 1); j++)
                {
                    if (unsortedList[j] > unsortedList[j + 1])
                    {
                        temp = unsortedList[j + 1];
                        unsortedList[j + 1] = unsortedList[j];
                        unsortedList[j] = temp;
                    }
                }
            }

            Console.WriteLine("\nAfter Bubble Sort");

            for (int index = 0; index < unsortedList.Length; index++)
            {
                Console.Write(unsortedList[index] + " ");
            }

            Console.ReadLine();
        }
    }
}
