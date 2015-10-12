namespace P7_GenericArraySort
{
    using System;

    internal sealed class App
    {
        internal static void Main()
        {
            int[] integerArray =
            {
                12, 4, 16, -8, 477646, -564, 726724, 1
            };
            
            string[] stringsArray =
            {
                "Varna", "Sofia", "Plovdiv", "Burgas", "Pleven",
                "Vidin", "Kaspichan", "Lovech", "Razgrad", "Koprivshtica"
            };
            
            DateTime[] datesArray =
            {
                new DateTime(2015, 2, 2),
                new DateTime(2004, 7, 5),
                new DateTime(2012, 8, 1),
                new DateTime(2017, 12, 12), 
                new DateTime(2005, 5, 4),
                new DateTime(1999, 1, 5),
                new DateTime(1902, 5, 6) 
            };

            SortArray(integerArray);
            SortArray(stringsArray);
            SortArray(datesArray);

            PrintArray(integerArray);
            PrintArray(stringsArray);
            PrintArray(datesArray);
        }

        /// <summary>
        /// Sorts the array using a BubbleSort implementation.
        /// </summary>
        /// <typeparam name="T">Any type (generic).</typeparam>
        /// <param name="array">The array to be sorted.</param>
        private static void SortArray<T>(T[] array) where T : IComparable
        {           
            for (int i = 0; i <= array.Length - 2; i++)
            {
                for (int j = 0; j <= array.Length - 2; j++)
                {
                    if (array[j].CompareTo(array[j + 1]) == 1)
                    {
                        T temp = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }

        /// <summary>
        /// Prints an array in a user-friendly way.
        /// </summary>
        /// <typeparam name="T">Any type (generic).</typeparam>
        /// <param name="array">The array to be printed.</param>
        private static void PrintArray<T>(T[] array)
        {
            Console.WriteLine("[ {0} ]", string.Join(", ", array));
        }
    }
}
