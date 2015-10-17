namespace P8_NightLife
{
    using System;
    using System.Collections.Generic;

    internal sealed class App
    {
        internal static void Main()
        {
            var data = new Dictionary<string, SortedDictionary<string, SortedSet<string>>>();
            string currentLine = Console.ReadLine();

            while (!currentLine.Equals("END"))
            {
                string[] splitData = currentLine.Split(';');
                string city = splitData[0];
                string venue = splitData[1];
                string performer = splitData[2];

                if (data.ContainsKey(city))
                {
                    if (data[city].ContainsKey(venue))
                    {
                        data[city][venue].Add(performer);
                    }
                    else
                    {
                        data[city].Add(venue, new SortedSet<string> { performer });
                    }
                }
                else
                {
                    data.Add(city, new SortedDictionary<string, SortedSet<string>>());
                    data[city].Add(venue, new SortedSet<string> { performer });
                }

                currentLine = Console.ReadLine();
            }

            foreach (var city in data)
            {
                Console.WriteLine("{0}", city.Key);
                
                foreach (var venue in city.Value)
                {
                    Console.WriteLine(
                        "->{0}: {1}",
                        venue.Key,
                        string.Join(", ", venue.Value));
                }
            }
        }
    }
}