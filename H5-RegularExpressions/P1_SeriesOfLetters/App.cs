namespace P1_SeriesOfLetters
{
    using System;
    using System.Text.RegularExpressions;

    internal sealed class App
    {
        internal static void Main()
        {
            Console.Write("Enter string: ");
            string inputLine = Console.ReadLine();
            string pattern = @"([a-zA-Z])\1*";
            MatchCollection matches = Regex.Matches(inputLine, pattern);
            Console.Write("Result: ");
            foreach (Match match in matches)
            {
                Console.Write(match.Groups[1].Value);
            }

            Console.WriteLine();
        }
    }
}