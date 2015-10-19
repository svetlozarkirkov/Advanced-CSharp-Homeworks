namespace P2_ReplaceAnchorTag
{
    using System;
    using System.Text.RegularExpressions;

    internal sealed class App
    {
        private const string AnchorTagPattern = 
                @"(<a href=)([""|']{1})(?<url>[^>|^'|^""]+)(\2)[>]{1}(?<title>[^<|^>]+)(<\/a>)";

        internal static void Main()
        {
            string firstString = @"<ul><li><a href=""http://softuni.bg"">SoftUni</a></li></ul>";
            string secondString = @"<ul><li><a href='http://softuni.bg'>SoftUni</a></li></ul>";
            
            // The string below is not matched (different quotations)
            string wrongString = @"<ul><li><a href='http://softuni.bg"">SoftUni</a></li></ul>";
            
            DisplayResult(firstString);
            DisplayResult(secondString);
            DisplayResult(wrongString);
        }

        private static string ReplaceAnchorTag(string input)
        {
            return Regex.Replace(
                input,
                AnchorTagPattern,
                m => "[URL href=" + m.Groups["url"] + "]" + m.Groups["title"] + "[/URL]");
        }

        private static int TotalMatches(string input)
        {
            return Regex.Matches(input, AnchorTagPattern).Count;
        }

        private static void DisplayResult(string input)
        {
            Console.WriteLine(
                "Replaced: {0}\nTotal matches: {1}\n",
                ReplaceAnchorTag(input),
                TotalMatches(input));
        }
    }
}