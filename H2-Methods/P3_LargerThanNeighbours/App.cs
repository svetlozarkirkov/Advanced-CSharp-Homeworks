namespace P3_LargerThanNeighbours
{
    using System;

    internal sealed class App
    {
        internal static void Main()
        {
            int[] numbers = { 1, 3, 4, 5, 1, 0, 5 };
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(IsLargerThanNeighbours(numbers, i));
            }
        }

        private static bool IsLargerThanNeighbours(int[] array, int index)
        {
            if (index == array.Length - 1)
            {
                return array[index] > array[index - 1];
            }
            
            if (index == 0)
            {
                return array[index] > array[index + 1];
            }

            return array[index] > array[index + 1] && array[index] > array[index - 1];
        }
    }
}