namespace P3_ExtractEmails
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    internal sealed class App
    {
        private const string EmailPattern =
            "([a-z0-9]+([-+._][a-z0-9]+){0,2}@.*?(\\.(a(?:[cdefgilmnoqrstuwxz]|ero" +
            "|(?:rp|si)a)|b(?:[abdefghijmnorstvwyz]iz)|c(?:[acdfghiklmnoruvxyz]" +
            "|at|o(?:m|op))|d[ejkmoz]|e(?:[ceghrstu]|du)|f[ijkmor]|g(?:[abdefghilmnpqrstuwy]" +
            "|ov)|h[kmnrtu]|i(?:[delmnoqrst]|n(?:fo|t))|j(?:[emop]|obs)|k[eghimnprwyz]" +
            "|l[abcikrstuvy]|m(?:[acdeghklmnopqrstuvwxyz]|il|obi|useum)|n(?:[acefgilopruz]" +
            "|ame|et)|o(?:m|rg)|p(?:[aefghklmnrstwy]|ro)|qa|r[eosuw]|s[abcdeghijklmnortuvyz]" +
            "|t(?:[cdfghjklmnoprtvwz]|(?:rav)?el)|u[agkmsyz]|v[aceginu]|w[fs]|y[etu]|z[amw])\\b){1,2})";

        internal static void Main()
        {
            Console.Write("Enter text: ");
            string inputText = Console.ReadLine();
            var foundEmails = ExtractEmails(inputText);
            foreach (var email in foundEmails)
            {
                Console.WriteLine("E-Mail found: {0}", email);
            }
        }

        private static SortedSet<string> ExtractEmails(string text)
        {
            var emailsCollected = new SortedSet<string>();
            MatchCollection matches = Regex.Matches(text, EmailPattern);
            foreach (Match match in matches)
            {
                emailsCollected.Add(match.Groups[0].Value);
            }
            
            return emailsCollected;
        } 
    }
}