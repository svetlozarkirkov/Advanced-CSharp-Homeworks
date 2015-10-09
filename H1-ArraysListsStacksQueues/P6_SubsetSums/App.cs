namespace P6_SubsetSums
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal sealed class App
    {
        internal static void Main()
        {
            Console.Write("Enter N: ");
            int searchedSum = int.Parse(Console.ReadLine());
            Console.Write("Enter ints (separated by space): ");
            int[] numbersSet = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var found = new List<List<int>>();
            foreach (var subset in GetSubsets(numbersSet))
            {
                List<int> subsetAsList = subset.ToList();
                subsetAsList.Sort();

                if (subset.Sum() == searchedSum && found.TrueForAll(x => !x.SequenceEqual(subsetAsList)))
                {
                    Console.WriteLine("{0} = {1}", string.Join(" + ", subset), searchedSum);
                    found.Add(subsetAsList);
                }
            }

            if (found.Count == 0)
            {
                Console.WriteLine("No matching subsets.");
            }
        }

        internal static List<int[]> GetSubsets(int[] array)
        {
            List<int[]> subsets = new List<int[]>();
            foreach (int element in array)
            {
                int subsetCount = subsets.Count;
                subsets.Add(new[] { element });
                for (int j = 0; j < subsetCount; j++)
                {
                    int[] newSubset = new int[subsets[j].Length + 1];
                    subsets[j].CopyTo(newSubset, 0);
                    newSubset[newSubset.Length - 1] = element;
                    subsets.Add(newSubset);
                }
            }

            return subsets;
        } 
    }
}