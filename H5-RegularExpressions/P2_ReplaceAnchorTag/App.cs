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
            Console.WriteLine(ReplaceAnchorTag(firstString));
            Console.WriteLine(ReplaceAnchorTag(secondString));
        }

        private static string ReplaceAnchorTag(string input)
        {
            string pattern = @"(<a href=[""|'])([^>]+)([""|']>)(\S+)(<\/a>)";

            return Regex.Replace(
                input,
                pattern,
                m => "[URL href=" + m.Groups[2].Value + "]" + m.Groups[4].Value + "[/URL]");
        }
    }
}