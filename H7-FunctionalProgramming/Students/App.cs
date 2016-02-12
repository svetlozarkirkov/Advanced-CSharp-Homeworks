namespace Students
{
    using System;
    using System.Collections.Generic;

    internal class App
    {
        internal static void Main()
        {
            var studentsList = new List<Student>
            {
                new Student("Bill", "Gates", 99, 1),
                new Student("Steve", "Jobs", 98, 2),
                new Student("Maria", "Petrova", 22, 3)
            };

            foreach (var student in studentsList)
            {
                Console.WriteLine(student);
            }
        }
    }
}