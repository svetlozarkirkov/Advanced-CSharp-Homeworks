namespace P5_LongestIncreasingSequence
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal sealed class App
    {
        internal static void Main()
        {
            Console.Write("Enter ints (separated by space): ");
            var inputNumsArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var inputNumsArrayLength = inputNumsArray.Length;
            var increasingSequences = new List<List<int>>();
            
            for (int currentIndex = 0; currentIndex < inputNumsArrayLength;)
            {
                var currentSequence = new List<int>();
                var current = inputNumsArray[currentIndex];
                currentSequence.Add(current);

                for (int nextIndex = currentIndex + 1; nextIndex < inputNumsArrayLength; nextIndex++)
                {
                    if (inputNumsArray[nextIndex] > current)
                    {
                        currentSequence.Add(inputNumsArray[nextIndex]);
                        current = inputNumsArray[nextIndex];
                        currentIndex++;
                    }
                    else
                    {
                        break;
                    }
                }

                increasingSequences.Add(currentSequence);
                currentIndex++;
            }

            increasingSequences.ForEach(x => Console.WriteLine(string.Join(" ", x)));
            
            var longestSequence = increasingSequences
                    .FindAll(x => x.Count == increasingSequences.Max(y => y.Count))
                    .First();
            
            Console.WriteLine("Longest: {0}", string.Join(" ", longestSequence));
        }
    }
}