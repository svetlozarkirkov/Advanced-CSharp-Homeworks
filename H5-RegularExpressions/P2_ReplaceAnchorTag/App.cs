namespace P2_ReplaceAnchorTag
{
    using System;
    using System.Text.RegularExpressions;

    internal sealed class App
    {
        internal static void Main()
        {
            string firstString = @"<ul><li><a href=""http://softuni.bg"">SoftUni</a></li></ul>";
            string secondString = @"<ul><li><a href='http://softuni.bg'>SoftUni</a></li></ul>";
            
            // The string below is not matched (different quotations)
            string wrongString = @"<ul><li><a href='http://softuni.bg"">SoftUni</a></li></ul>";
            
            Console.WriteLine("First string: {0}", ReplaceAnchorTag(firstString));
            Console.WriteLine("Second string: {0}", ReplaceAnchorTag(secondString));
            Console.WriteLine("Wrong string: {0}", ReplaceAnchorTag(wrongString));
        }

        private static string ReplaceAnchorTag(string input)
        {
            string pattern = @"(<a href=)([""|']{1})(?<url>[^>|^'|^""]+)(\2)[>]{1}(?<title>\S+)(<\/a>)";

            return Regex.Replace(
                input,
                pattern,
                m => "[URL href=" + m.Groups["url"] + "]" + m.Groups["title"] + "[/URL]");
        }
    }
}