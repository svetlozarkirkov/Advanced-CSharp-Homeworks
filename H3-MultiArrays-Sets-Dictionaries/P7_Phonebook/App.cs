namespace P7_Phonebook
{
    using System;
    using System.Collections.Generic;

    internal sealed class App
    {
        internal static void Main()
        {
            var phonebook = new Dictionary<string, List<string>>();
            Console.WriteLine("Enter data in format NAME-PHONENUMBER:");
            string currentLine = Console.ReadLine();

            while (!currentLine.Equals("search"))
            {
                string[] splitData = currentLine.Split('-');
                string name = splitData[0];
                string phoneNumber = splitData[1];
                
                if (phonebook.ContainsKey(name))
                {
                    phonebook[name].Add(phoneNumber);
                }
                else
                {
                    phonebook.Add(name, new List<string> { phoneNumber });
                }

                currentLine = Console.ReadLine();
            }

            string searchedName = Console.ReadLine();
            
            while (!searchedName.Equals("END"))
            {
                if (phonebook.ContainsKey(searchedName))
                {
                    Console.WriteLine(
                        "{0} -> [ {1} ]", 
                        searchedName,
                        string.Join(", ", phonebook[searchedName]));
                }
                else
                {
                    Console.WriteLine("Contact {0} does not exist.", searchedName);
                }

                searchedName = Console.ReadLine();
            }
        }
    }
}