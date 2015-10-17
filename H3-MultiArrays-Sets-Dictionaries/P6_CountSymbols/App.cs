namespace P6_CountSymbols
{
    using System;
    using System.Linq;

    internal sealed class App
    {
        internal static void Main()
        {
            Console.Write("Enter text: ");
            string text = Console.ReadLine();
            if (string.IsNullOrEmpty(text))
            {
                Console.WriteLine("Invalid text!");
                return;
            }

            var dictionary = text
                        .GroupBy(c => c)
                        .OrderBy(c => c.Key)
                        .ToDictionary(grp => grp.Key, grp => grp.Count());
            
            foreach (var pair in dictionary)
            {
                Console.WriteLine("{0}: {1} time/s", pair.Key, pair.Value);
            }
        }
    }
}