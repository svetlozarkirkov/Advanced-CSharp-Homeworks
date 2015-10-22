namespace P3_WordCount
{
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text.RegularExpressions;

    internal sealed class App
    {
        internal static void Main()
        {
            // The created file (result.txt) is in bin\Debug
            // The usings are chained for less nesting
            using (var resultWriter = new StreamWriter("result.txt"))
            using (var wordsReader = new StreamReader("words.txt"))
            using (var textReader = new StreamReader("text.txt"))
            {
                var words = new Dictionary<string, int>();
                string wordsTxtLine;
                while ((wordsTxtLine = wordsReader.ReadLine()) != null)
                {
                    words.Add(wordsTxtLine, 0);
                }

                string textTxtLine;
                while ((textTxtLine = textReader.ReadLine()) != null)
                {
                    var matches = Regex.Matches(textTxtLine, @"\b[\w']*\b");
                    foreach (Match match in matches)
                    {
                        string currentWord = match.Groups[0].Value;
                        if (words.ContainsKey(currentWord))
                        {
                            words[currentWord] += 1;
                        }
                    }
                }

                var sortedWords = from entry in words orderby entry.Value descending select entry;
                
                foreach (KeyValuePair<string, int> entry in sortedWords)
                {
                    resultWriter.WriteLine("{0} - {1}", entry.Key, entry.Value);
                }
            }
        }
    }
}