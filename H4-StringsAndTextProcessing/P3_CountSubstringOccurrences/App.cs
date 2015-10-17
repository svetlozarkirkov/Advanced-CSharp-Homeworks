namespace P3_CountSubstringOccurrences
{
    using System;

    internal sealed class App
    {
        internal static void Main()
        {
            string text = Console.ReadLine().ToLowerInvariant();
            char[] textChars = text.ToCharArray();
            string searchedSubstring = Console.ReadLine().ToLowerInvariant();
            int count = 0;
            if (searchedSubstring.Length > textChars.Length)
            {
                Console.WriteLine(count);
                return;
            }

            for (int current = 0; current <= textChars.Length - searchedSubstring.Length; current++)
            {
                if (new string(textChars, current, searchedSubstring.Length).Equals(searchedSubstring))
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}