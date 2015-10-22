namespace P2_LineNumbers
{
    using System.IO;

    internal sealed class App
    {
        internal static void Main()
        {
            // The created file (text_with_line_numbers.txt) is in bin\Debug
            // The usings are chained for less nesting
            using (var writer = new StreamWriter("text_with_line_numbers.txt"))
            using (var reader = new StreamReader("text.txt"))
            {
                int count = 1;

                while (!reader.EndOfStream)
                {
                    var currentLine = reader.ReadLine();
                    writer.WriteLine("{0} -> {1}", count, currentLine);
                    count++;
                }
            }
        }
    }
}