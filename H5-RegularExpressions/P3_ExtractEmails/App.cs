using System.Collections.Generic;

namespace P3_ExtractEmails
{
    using System;

    internal sealed class App
    {
        internal static void Main()
        {
            Console.Write("Enter text: ");
            string inputText = Console.ReadLine();
        }

        private static SortedSet<string> ExtractEmails(string text)
        {
            var emailsCollected = new SortedSet<string>();

            return emailsCollected;
        } 
    }
}