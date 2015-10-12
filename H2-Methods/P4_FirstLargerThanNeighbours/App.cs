namespace P4_FirstLargerThanNeighbours
{
    using System;

    internal sealed class App
    {
        internal static void Main()
        {
            int[] sequenceOne = { 1, 3, 4, 5, 1, 0, 5 };
            int[] sequenceTwo = { 1, 2, 3, 4, 5, 6, 6 };
            int[] sequenceThree = { 1, 1, 1 };

            Console.WriteLine(GetIndexOfFirstElementLargerThanNeighbours(sequenceOne));
            Console.WriteLine(GetIndexOfFirstElementLargerThanNeighbours(sequenceTwo));
            Console.WriteLine(GetIndexOfFirstElementLargerThanNeighbours(sequenceThree));
        }

        private static int GetIndexOfFirstElementLargerThanNeighbours(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (IsLargerThanNeighbours(array, i))
                {
                    return i;
                }
            }

            return -1;
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
