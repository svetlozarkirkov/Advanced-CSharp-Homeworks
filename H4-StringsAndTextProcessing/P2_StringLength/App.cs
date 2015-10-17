namespace P2_StringLength
{
    using System;
    using System.Linq;

    internal sealed class App
    {
        internal static void Main()
        {
            Console.Write("Enter text: ");
            string input = Console.ReadLine();
            Console.Write("Result: ");
            
            if (input.Length >= 20)
            {
                Console.WriteLine(new string(input.Take(20).ToArray()));
            }
            else
            {
                Console.WriteLine(string.Concat(input, new string('*', 20 - input.Length)));
            }
        }
    }
}