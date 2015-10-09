namespace P4_SequencesOfEqualStrings
{
    using System;

    internal sealed class App
    {
        internal static void Main()
        {
            Console.Write("Enter strings (separated by space): ");
            var inputArray = Console.ReadLine().Split(' ');
            
            for (int currentIndex = 0; currentIndex < inputArray.Length;)
            {
                Console.Write(inputArray[currentIndex]);
                var currentString = inputArray[currentIndex];

                for (int nextIndex = currentIndex + 1; nextIndex < inputArray.Length; nextIndex++)
                {
                    if (inputArray[nextIndex].Equals(currentString))
                    {
                        Console.Write(" {0}", inputArray[nextIndex]);
                        currentIndex++;
                    }
                    else
                    {
                        break;
                    }
                }

                Console.WriteLine();
                currentIndex++;
            }
        }
    }
}