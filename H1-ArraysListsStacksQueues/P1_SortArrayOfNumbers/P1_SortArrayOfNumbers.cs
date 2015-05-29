using System;
using System.Linq;

namespace P1_SortArrayOfNumbers
{
    class P1_SortArrayOfNumbers
    {
        static void Main()
        {
            int[] input = Console.ReadLine().Split(' ').Select(n => Convert.ToInt32(n)).ToArray();
            Array.Sort(input);
            Console.WriteLine(string.Join(" ", input));
        }
    }
}
