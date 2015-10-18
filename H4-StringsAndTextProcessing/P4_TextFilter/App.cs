namespace P4_TextFilter
{
    using System;

    internal sealed class App
    {
        internal static void Main()
        {
            Console.Write("Banned words:\n");
            string[] bannedWords = Console.ReadLine().Split(
                new[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
            Console.Write("Text:\n");
            char[] textCharacters = Console.ReadLine().ToCharArray();
            
            foreach (string bannedWord in bannedWords)
            {
                int bannedLength = bannedWord.Length;
                
                for (int textIndex = 0; textIndex < textCharacters.Length - bannedLength; textIndex++)
                {
                    if (new string(textCharacters, textIndex, bannedLength).Equals(bannedWord))
                    {
                        for (int index = textIndex; index < textIndex + bannedLength; index++)
                        {
                            textCharacters[index] = '*';
                        }
                    }
                }
            }
            
            Console.WriteLine("Result:\n{0}", new string(textCharacters));
        }
    }
}