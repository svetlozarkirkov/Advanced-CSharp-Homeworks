using System.Collections;

namespace P2_SortArrayOfNumbersSelectionSort
{
    using System;
    using System.Linq;

    internal sealed class App
    {
        internal static void Main()
        {
            Console.Write("Enter ints (separated by space): ");
            var inputLine = Console.ReadLine();
            if (!string.IsNullOrEmpty(inputLine))
            {
                int[] array = inputLine
                    .Split(' ')
                    .Select(int.Parse)
                    .ToArray();

                SelectionSort(array);

                Console.WriteLine(
                    "Using SelectionSort: [ {0} ]", 
                    string.Join(", ", array));
            }
        }

        internal static void SelectionSort(int[] array)
        {
            int arrayLength = array.Length;

            for (int current = 0; current < arrayLength - 1; current++)
            {
                int minElementIndex = current;

                for (int next = current + 1; next < arrayLength; next++)
                {
                    if (array[next] < array[minElementIndex])
                    {
                        minElementIndex = next;
                    }
                }

                if (minElementIndex != current)
                {
                    int temp = array[current];
                    array[current] = array[minElementIndex];
                    array[minElementIndex] = temp;
                }
            }
        }
    }
}