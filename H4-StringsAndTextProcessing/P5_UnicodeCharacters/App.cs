namespace P5_UnicodeCharacters
{
    using System;

    internal sealed class App
    {
        internal static void Main()
        {
            Console.Write("String: ");
            char[] stringChars = Console.ReadLine().ToCharArray();
            Console.Write("Result: ");
            foreach (char symbol in stringChars)
            {
                Console.Write("\\U{0:x4}", (int)symbol);
            }

            Console.WriteLine();
        }
    }
}