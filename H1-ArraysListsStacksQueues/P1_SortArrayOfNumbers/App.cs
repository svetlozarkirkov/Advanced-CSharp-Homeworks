namespace P1_SortArrayOfNumbers
{
    using System;
    using System.Linq;

    internal sealed class App
    {
        internal static void Main()
        {
            Console.Write("Enter ints (separated by space): ");
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Array.Sort(input);
            Console.WriteLine("Sorted: [ {0} ]", string.Join(", ", input));
        }
    }
}