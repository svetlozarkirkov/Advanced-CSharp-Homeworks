namespace P4_SentenceExtractor
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;

    internal sealed class App
    {
        private const string SentencePattern = "([^.|^!|^?]+[?|!?.])";

        internal static void Main()
        {
            Console.Write("Keyword: ");
            string keyword = Console.ReadLine();
            Console.Write("Text: ");
            string text = Console.ReadLine();
            
            foreach (Match match in Regex.Matches(text, SentencePattern))
            {
                string currentSentence = match.Groups[0].Value.Trim();
                string[] currentSentenceWords = currentSentence.Split(' ');
                if (currentSentenceWords.Contains(keyword))
                {
                    Console.WriteLine(currentSentence);
                }
            }
        }
    }
}