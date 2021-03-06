﻿namespace P3_CategorizeNumbersFindMinMaxAvg
{
    using System;
    using System.Linq;

    internal sealed class App
    {
        internal static void Main()
        {
            Console.Write("Enter floating-point numbers (separated by space): ");
            double[] inputNumbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            PrintResult(inputNumbers.Where(x => x % 1 != 0).ToArray());
            PrintResult(inputNumbers.Where(x => x % 1 == 0).ToArray());
        }

        internal static void PrintResult(double[] numbers)
        {
            Console.WriteLine(
                "[ {0} ] -> min: {1}, max: {2}, sum: {3}, avg: {4:F2}",
                string.Join(", ", numbers),
                numbers.Min(),
                numbers.Max(),
                numbers.Sum(),
                numbers.Average());
        }
    }
}