namespace P1_SortArrayOfNumbers
{
    using System;
    using System.Linq;

    internal sealed class App
    {
        internal static void Main()
        {
            int[] input = Console.ReadLine().Split(' ').Select(n => Convert.ToInt32(n)).ToArray();
            Array.Sort(input);
            Console.WriteLine(string.Join(" ", input));
        }
    }
}