namespace P5_LongestIncreasingSequence
{
    using System;
    using System.Linq;

    internal sealed class App
    {
        internal static void Main()
        {
            Console.Write("Enter ints (separated by space): ");
            var inputNumsArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        }
    }
}
