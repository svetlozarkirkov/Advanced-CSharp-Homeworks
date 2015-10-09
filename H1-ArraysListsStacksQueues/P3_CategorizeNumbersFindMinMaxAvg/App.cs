using System.Collections.Generic;

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
                List<double> hasFractionNums = new List<double>();
                List<double> noFractionNums = new List<double>();
                
                double[] numbers = inputLine
                    .Split(' ')
                    .Select(double.Parse)
                    .ToArray();

                foreach (var num in numbers)
                {
                    if (num % 1 == 0)
                    {
                        noFractionNums.Add(num);
                    }
                    else
                    {
                        hasFractionNums.Add(num);
                    }
                }
                
                PrintNumbersList("Numbers with fraction:", hasFractionNums);
                PrintNumbersList("Numbers with zero fraction:", noFractionNums);
            }
        }

        internal static void PrintNumbersList(string introAppend, List<double> numbers)
        {
            Console.WriteLine(
                "{0} [ {1} ] -> min: {2}, max: {3}, sum: {4}, avg: {5:F2}",
                introAppend,
                string.Join(", ", numbers),
                numbers.Min(),
                numbers.Max(),
                numbers.Sum(),
                numbers.Average());
        }
    }
}
