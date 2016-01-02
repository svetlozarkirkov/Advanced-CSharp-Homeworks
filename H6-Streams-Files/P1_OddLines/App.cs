namespace P1_OddLines
{
    using System;
    using System.IO;

    internal sealed class App
    {
        internal static void Main()
        {
            int count = 0;
            using (var reader = new StreamReader("text.txt"))
            {
                while (!reader.EndOfStream)
                {
                    if (count % 2 != 0)
                    {
                        Console.WriteLine("Line N{0}: {1}", count, reader.ReadLine());
                    }
                    else
                    {
                        reader.ReadLine();
                    }

                    count++;
                }
            }
        }
    }
}