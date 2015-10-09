namespace P3_CategorizeNumbersFindMinMaxAvg
{
    using System;
    using System.Linq;

    internal sealed class App
    {
        internal static void Main()
        {
            Console.Write("Enter floating-point numbers (separated by space): ");
            var inputLine = Console.ReadLine();
            if (!string.IsNullOrEmpty(inputLine))
            {           
                double[] inputNumbers = inputLine
                    .Split(' ')
                    .Select(double.Parse)
                    .ToArray();
                
                double[] numbersWithFraction = inputNumbers
                    .Where(x => x % 1 != 0)
                    .ToArray();
                
                double[] numbersWithoutFraction = inputNumbers
                    .Where(x => x % 1 == 0)
                    .ToArray();
                
                PrintResult(numbersWithFraction);
                PrintResult(numbersWithoutFraction);
            }
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
