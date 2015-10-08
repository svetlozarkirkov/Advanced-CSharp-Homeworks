namespace P2_SortArrayOfNumbersSelectionSort
{
    using System;
    using System.Linq;

    internal sealed class App
    {
        internal static void Main()
        {
            Console.Write("Enter ints separated by space: ");
            int[] array = Console.ReadLine()
                .Split(' ')
                .Select(x => int.Parse(x))
                .ToArray();

            SelectionSort(array);

            Console.WriteLine("Sorted using SelectionSort method: [ {0} ]", 
                string.Join(", ", array));
        }

        internal static void SelectionSort(int[] array)
        {
            int arrayLength = array.Length;

            for (int current = 0; current < arrayLength - 1; current++)
            {
                int minIndex = current;

                for (int next = current + 1; next < arrayLength; next++)
                {
                    if (array[next] < array[minIndex])
                    {
                        minIndex = next;
                    }
                }

                if (minIndex != current)
                {
                    int temp = array[current];
                    array[current] = array[minIndex];
                    array[minIndex] = temp;
                }
            }
        }
    }
}