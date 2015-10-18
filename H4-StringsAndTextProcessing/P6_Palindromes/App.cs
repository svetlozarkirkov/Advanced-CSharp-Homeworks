namespace P6_Palindromes
{
    using System;
    using System.Collections.Generic;

    internal sealed class App
    {
        internal static void Main()
        {
            char[] delimiters = { ' ', ',', '.', '?', '!' };
            var palindromes = new SortedSet<string>();
            Console.Write("Text: ");
            string[] words = Console.ReadLine().Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
            foreach (var word in words)
            {
                if (IsPalindrome(word) && !palindromes.Contains(word))
                {
                    palindromes.Add(word);
                }
            }

            Console.WriteLine("Palindromes: {0}", string.Join(", ", palindromes));
        }

        private static bool IsPalindrome(string word)
        {
            int left = 0;
            int right = word.Length - 1;
            while (true)
            {
                if (left > right)
                {
                    return true;
                }
                
                char a = word[left];
                char b = word[right];
                
                if (a != b)
                {
                    return false;
                }

                left++;
                right--;
            }
        }
    }
}