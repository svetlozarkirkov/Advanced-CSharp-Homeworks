namespace P1_ReverseString
{
    using System;
    using System.Linq;

    internal sealed class App
    {
        internal static void Main()
        {
            Console.Write("Enter string: ");
            string input = Console.ReadLine();
            string reversed = new string(input.ToCharArray().Reverse().ToArray());
            Console.WriteLine("Reversed: {0}", reversed);
        }
    }
}
